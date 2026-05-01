using Draft;
using System;
using System.Windows.Forms;

namespace Sistema_Autonomo_Predadores
{
    public partial class Lobby : Form
    {
        private Jogador _jogador;
        private Partida _partida;
        private Turno _turno;

        public Lobby()
        {
            InitializeComponent();
            lblVersao.Text = "Versão: " + Jogo.versao;

            _jogador = new Jogador();
            _partida = new Partida();
            _turno = new Turno();
        }

        // ── Seleção de Partida ──────────────────────────────────────────────────

        private void btnPartidas_Click(object sender, EventArgs e)
        {
            var form = new ListarPartidas();
            form.ShowDialog();

            if (form.PartidaSelecionada != null)
            {
                _partida = form.PartidaSelecionada;
                txtID.Text = _partida.Id.ToString();
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

        // ── Gerenciamento de Partida ────────────────────────────────────────────

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(txtNome, txtSenha)) return;

            string retorno = Jogo.CriarPartida(txtNome.Text, txtSenha.Text, lblNome.Text);

            if (retorno.Contains("ERRO"))
            {
                MostrarErro(retorno);
                return;
            }

            txtID.Text = retorno;
            txtSenhaPartida.Text = txtSenha.Text;
            MostrarSucesso("Partida criada com sucesso!");
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos(txtID, txtSenhaPartida, txtJogador)) return;

            _partida.Id = Convert.ToInt32(txtID.Text);
            _partida.Senha = txtSenhaPartida.Text;
            _jogador.Nome = txtJogador.Text;

            string retorno = Jogo.Entrar(_partida.Id, _jogador.Nome, _partida.Senha);

            if (!retorno.Contains(","))
            {
                MostrarErro(retorno);
                return;
            }

            string[] info = retorno.Split(',');
            _jogador.Id = Convert.ToInt32(info[0]);
            _jogador.Senha = info[1];

            lblID.Text = $"ID {_jogador.Nome}: {_jogador.Id}";
            lblSenha.Text = $"Senha {_jogador.Nome}: {_jogador.Senha}";
            MostrarSucesso($"{_jogador.Nome} entrou na partida.");
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.Iniciar(_jogador.Id, _jogador.Senha);

            if (retorno.Contains("ERRO"))
                MostrarErro(retorno);
            else
                MostrarSucesso("Partida iniciada com sucesso!");
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (!AtualizarDados()) return;

            var telaJogo = new FrmJogo();
            telaJogo.AtualizarInfoTurno(_jogador.Nome, _jogador.Id, _jogador.Senha, _partida.Id);
            telaJogo.Show();
        }

        // ── Tabela de Jogadores ─────────────────────────────────────────────────

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarTabelaJogadores();
        }

        private void AtualizarTabelaJogadores()
        {
            dgvListarJogadores.DataSource = Jogador.ListarJogadores(_partida.Id);

            dgvListarJogadores.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListarJogadores.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvListarJogadores.AllowUserToResizeColumns = false;
            dgvListarJogadores.AllowUserToResizeRows = false;
            dgvListarJogadores.RowHeadersVisible = false;

            dgvListarJogadores.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListarJogadores.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgvListarJogadores.Columns[2].Visible = false;
        }

        // ── Navegação ───────────────────────────────────────────────────────────

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // ── Helpers ─────────────────────────────────────────────────────────────

        /// <summary>
        /// Consulta o servidor e atualiza _partida e _turno com os dados atuais.
        /// Retorna false se houver erro.
        /// </summary>
        public bool AtualizarDados()
        {
            string retorno = Jogo.VerificarPartida(_partida.Id);

            if (!_partida.CarregarDeVerificacao(retorno, _turno))
            {
                MostrarErro(retorno);
                return false;
            }

            return true;
        }

        private bool ValidarCampos(params System.Windows.Forms.TextBox[] campos)
        {
            foreach (var campo in campos)
            {
                if (string.IsNullOrWhiteSpace(campo.Text))
                {
                    MessageBox.Show(
                        "Algum campo não foi preenchido!",
                        "Atenção",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning
                    );
                    return false;
                }
            }
            return true;
        }

        private void MostrarErro(string mensagem) =>
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        private void MostrarSucesso(string mensagem) =>
            MessageBox.Show(mensagem, "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

    }
}