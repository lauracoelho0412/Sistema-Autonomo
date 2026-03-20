using Draft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Sistema_Autonomo_Predadores
{
    public partial class Form1 : Form
    {
        Jogador jogador;
        public Form1()
        {
            InitializeComponent();

            // Configurações para os Labels
            lblVersao.Text = "Versão: " + Jogo.versao;

            // Configurações para os TextBox
            txtJogadores.Multiline = true;
            txtJogadores.ScrollBars = ScrollBars.Vertical;
            txtPartidas.Multiline = true;
            txtPartidas.ScrollBars = ScrollBars.Vertical;

            jogador = new Jogador();
        }

        private void btn_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.ListarPartidas("T");
            txtPartidas.Text = retorno;

            retorno = retorno.Replace("\r", "");
            retorno = retorno.Substring(0, retorno.Length - 1);
            string[] partidas = retorno.Split('\n');

        }

        private void btnCriarPartida_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtSenha.Text == "")
            {
                MessageBox.Show("Algum campo não foi preenchido!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string retorno = Jogo.CriarPartida(txtNome.Text, txtSenha.Text, lblNome.Text);
                if (retorno.Contains("ERRO"))
                {
                    MessageBox.Show(retorno, "atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    txtID.Text = retorno;
                    txtSenhaPartida.Text = txtSenha.Text;
                    MessageBox.Show("Partida criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
              
            }
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "" || txtSenhaPartida.Text == "" || txtJogador.Text == "")
            {
                MessageBox.Show("Algum campo não foi preenchido!", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string retorno = Jogo.Entrar(int.Parse(txtID.Text), txtJogador.Text, txtSenhaPartida.Text);
                if(retorno.Contains(","))
                {
                    string[] info = retorno.Split(',');

                    jogador.id = int.Parse(info[0]);
                    jogador.nome = txtJogador.Text; 
                    jogador.senha = info[1];

                    lblID.Text = $"ID {jogador.nome}: " + jogador.id;
                    lblSenha.Text = $"Senha {jogador.nome}: " + jogador.senha;
                    lblJogador.Text = $"Jogador: " + jogador.nome;

                    MessageBox.Show(jogador.nome + " entrou na partida", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(retorno,  "atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnJogadores_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "")
            {
                MessageBox.Show("Campo ID não preenchido!", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string retorno = Jogo.ListarJogadores(int.Parse(txtID.Text));

            if (retorno == null || retorno == "")
            {
                MessageBox.Show("Nenhum jogador encontrado para essa partida!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
               txtJogadores.Text = retorno;
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            Jogo.Iniciar(jogador.id, jogador.senha);
            lblMmao.Text = Jogo.ExibirMao(jogador.id, jogador.senha);
        }
    }
}
