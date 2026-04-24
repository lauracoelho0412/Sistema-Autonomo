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
        private FrmJogo telaJogo;
        private Jogador _jogador;
        private Partida _partida;
        private Turno _turno;



        public Lobby()
        {
            InitializeComponent();

            // Exibe a versão atual do jogo no label de rodapé
            lblVersao.Text = "Versão: " + Jogo.versao;

            // Inicializa os objetos de estado com valores padrão
            _jogador = new Jogador();
            _partida = new Partida();
            _turno = new Turno();
        }

        // ── Eventos de Botões 

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
                txtID.Text = retorno;
                txtSenhaPartida.Text = txtSenha.Text;

                MessageBox.Show(
                    "Partida criada com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );

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

            _partida.Id = Convert.ToInt32(txtID.Text);
            _partida.Senha = txtSenhaPartida.Text;
            _jogador.Nome = txtJogador.Text;

            string retorno = Jogo.Entrar(_partida.Id, _jogador.Nome, _partida.Senha);

            if (retorno.Contains(","))
            {
                string[] info = retorno.Split(',');

                _jogador.Id = Convert.ToInt32(info[0]);
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
            else
            {
                MessageBox.Show(
                    "Partida iniciada com sucesso!",
                    "Sucesso",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information
                );
            }
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            if (AtualizarDados())
            {
                telaJogo = new FrmJogo();

                telaJogo.AtualizarInfoTurno(
                    _jogador.Nome,
                    _jogador.Id,
                    _jogador.Senha,
                    _partida.Id
                );

                telaJogo.Show();
            }
        }



        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            AtualizarTabela();
        }

        private void AtualizarTabela()
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

        public bool AtualizarDados()
        {
            string retorno = Jogo.VerificarPartida(_partida.Id);
            if (retorno.Contains("ERRO"))
            {
                MessageBox.Show(retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            else
            {
                string[] infoPartida = retorno.Split(',');
                _partida.Status = infoPartida[0];
                _turno.TurnoAtual = Convert.ToInt32(infoPartida[1]);
                _turno.Status = infoPartida[2];
                _turno.IdJogadorDado = Convert.ToInt32(infoPartida[3]);
                _turno.Dado = infoPartida[4];
                return true;
            }
        }
    }
}
    

