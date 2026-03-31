using Draft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_Autonomo_Predadores
{
    public partial class Lobby : Form
    {
        // ── Estado interno do Lobby ──────────────────────────────────────────
        private Jogador _jogador;
        private Partida _partida;
        private Turno _turno;
        private Dinossauro _dinossauro;

        public Lobby()
        {
            InitializeComponent();

            // Exibe a versão atual do jogo no label de rodapé
            lblVersao.Text = "Versão: " + Jogo.versao;

            // Inicializa os objetos de estado com valores padrão
            _jogador = new Jogador();
            _partida = new Partida();
            _turno = new Turno();
            _dinossauro = new Dinossauro();
        }

        // ── Eventos de Botões ────────────────────────────────────────────────

        private void btn_Click(object sender, EventArgs e)
        {
            ListarPartidas formListarPartidas = new ListarPartidas();
            formListarPartidas.ShowDialog();

            if (formListarPartidas.PartidaSelecionada != null)
            {
                _partida = formListarPartidas.PartidaSelecionada;
                txtID.Text = Convert.ToString(_partida.Id);
            }
            else
            {
                MessageBox.Show(
                    "Nenhuma partida foi selecionada.",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
            }
        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNome.Text) || string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show(
                    "Algum campo não foi preenchido!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string retorno = Jogo.CriarPartida(txtNome.Text, txtSenha.Text, lblNome.Text);

            if (retorno.Contains("ERRO"))
            {
                MessageBox.Show(retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                // Armazena o ID retornado e atualiza os campos visuais
                _partida.Id = Convert.ToInt32(retorno);
                txtID.Text = retorno;
                txtSenhaPartida.Text = txtSenha.Text;
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text)
                || string.IsNullOrEmpty(txtSenhaPartida.Text)
                || string.IsNullOrEmpty(txtJogador.Text))
            {
                MessageBox.Show(
                    "Algum campo não foi preenchido!",
                    "Atenção",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                );
                return;
            }

            string retorno = Jogo.Entrar(int.Parse(txtID.Text), txtJogador.Text, txtSenhaPartida.Text);

            // Retorno com vírgula indica sucesso: "id,senha"
            if (retorno.Contains(","))
            {
                string[] info = retorno.Split(',');

                _jogador.Id = Convert.ToInt32(info[0]);
                _jogador.Nome = txtJogador.Text;
                _jogador.Senha = info[1];

                // Exibe os dados do jogador autenticado na tela
                lblID.Text = $"ID {_jogador.Nome}: {_jogador.Id}";
                lblSenha.Text = $"Senha {_jogador.Nome}: {_jogador.Senha}";

                MessageBox.Show(
                    $"{_jogador.Nome} entrou na partida",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
            else
            {
                MessageBox.Show(retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.Iniciar(_jogador.Id, _jogador.Senha);

            if (retorno.Contains("ERRO"))
            {
                MessageBox.Show(retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Extrai o ID do jogador que rolou o dado e o resultado do dado
            string[] dadoInfo = retorno.Split(',');
            _turno.IdJogadorDado = Convert.ToInt32(dadoInfo[0]);
            _turno.Dado = dadoInfo[1];

            // Busca a mão de dinossauros do jogador e determina o número do turno
            string mao = Jogo.ExibirMao(_jogador.Id, _jogador.Senha);

            // O número do turno está no primeiro campo da mão formatada
            string maoFormatada = mao.Replace("\n", ",");
            string[] camposMao = maoFormatada.Split(',');
            _turno.TurnoAtual = Convert.ToInt32(camposMao[0]);

            // Atualiza os labels de dado, jogador e dinossauros na interface
            lblDado.Text = _turno.Dado;
            lblJDado.Text = ObterNomeJogadorDado(_partida.Id);
            lblDino.Text = mao;
            RealizarJogada(Dinossauro.ListarDinossauros(mao), _turno.Dado);

        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            dgvListarJogadores.DataSource = Jogador.ListarJogadores(_partida.Id);

            // Configurações de interação e visual da tabela de jogadores
            dgvListarJogadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListarJogadores.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvListarJogadores.AllowUserToResizeColumns = false;
            dgvListarJogadores.AllowUserToResizeRows = false;
            dgvListarJogadores.RowHeadersVisible = false;

            // Configura as colunas: nome preenche o espaço, senha fica oculta
            dgvListarJogadores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListarJogadores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListarJogadores.Columns[2].Visible = false;
        }

        // ── Métodos Auxiliares ───────────────────────────────────────────────

        private string ObterNomeJogadorDado(int idPartida)
        {
            List<Jogador> jogadores = Jogador.ListarJogadores(idPartida);

            foreach (Jogador jogador in jogadores)
            {
                if (jogador.Id == _turno.IdJogadorDado)
                    return jogador.Nome;
            }

            return "Jogador não encontrado!";
        }

        private string RealizarJogada(List<Dinossauro> mao, string dado)
        {
            // Verifica se há dinossauros disponíveis antes de tentar jogar
            if (mao == null || mao.Count == 0)
            {
                MessageBox.Show("Mão do jogador está vazia!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "ERRO: Mão vazia";
            }

            // Fazer campo de lógica para jogada, criar novo arquivo para isso, ou criar classe de sistema autônomo
            string codigoDino = "";
            string codigoCercado = "";

            // Valida se o sistema retornou uma jogada válida
            if (codigoDino == null || codigoCercado == null)
            {
                MessageBox.Show("Não foi possível determinar uma jogada válida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "ERRO: Jogada inválida";
            }

            // Exibe na interface qual jogada foi decidida pelo sistema autônomo
            lblJogada.Text = $"Jogando: {codigoDino} → Cercado: {codigoCercado}";

            // Envia a jogada para o servidor via DLL
            string resposta = Jogo.Jogar(_jogador.Id, _jogador.Senha, codigoDino, codigoCercado);

            if (resposta.Contains("ERRO"))
            {
                MessageBox.Show(resposta, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return resposta;
            }

            // A resposta é o número do próximo turno
            _turno.TurnoAtual = Convert.ToInt32(resposta);
            lblDado.Text = $"Próximo turno: {_turno.TurnoAtual}";

            return resposta;
        }
    }
}
    

