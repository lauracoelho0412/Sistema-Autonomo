using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Resources.ResXFileRef;

namespace Sistema_Autonomo_Predadores
{

    //----JA AQUI---
    // MOSTRAR O TABULEIRO
    //MOSTRAR OS DINOS
    //MOSTRAR HUD (TURNO, DADO, JOGADOR, MAO)
    public partial class FrmJogo : Form
    {
        private string maoAtual;
        public FrmJogo()
        {
            InitializeComponent();
        }




        //tira o fundo branco dos panel INDIVIDUAL
        private void FrmJogo_Load(object sender, EventArgs e)
        {
            panelFI.Parent = pbTabuleiro;
            panelFI.BackColor = Color.Transparent;

            panelPA.Parent = pbTabuleiro;
            panelPA.BackColor = Color.Transparent;

            panelIS.Parent = pbTabuleiro;
            panelIS.BackColor = Color.Transparent;

            panelMT.Parent = pbTabuleiro;
            panelMT.BackColor = Color.Transparent;

            panelCD.Parent = pbTabuleiro;
            panelCD.BackColor = Color.Transparent;

            panelRS.Parent = pbTabuleiro;
            panelRS.BackColor = Color.Transparent;


            this.DoubleBuffered = true; // evita flicker
          this.Refresh();

        }


        //ATUALIZA A PRIMEIRA ENTRADA DO JOGO
        public void AtualizarInfoTurno(string jogador, string dado, int turno, string mao)
        {
            lblJogadorDado.Text = "Jogador: " + jogador;
            lblDado.Text = "Dado: " + dado;
            lblTurno.Text = "Turno: " + turno;
            lblMao.Text = "Mão: " + mao;

            maoAtual = mao; // salva a mão
        }


        //RECEBE
        public void ReceberJogada(string dino, string cercado)
        {
            AdicionarDino(dino, cercado);
        }


        //PRINCIPAL - ADICIONAR
        private void AdicionarDino(string nomeDino, string cercado)
        {
            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.Zoom;


            // Declare a variável dinoSize ANTES de usar
            int dinoSize = 50; // tamanho fixo do dino, esta muito pequeno tem q ajustar isso 
            pb.Width = dinoSize;
            pb.Height = dinoSize;

            // Configura o tamanho fixo para todos
            int tamanhoDino = 50;
            pb.Width = tamanhoDino;
            pb.Height = tamanhoDino;


            //  dino
            nomeDino = nomeDino.ToUpper();
            switch (nomeDino)
            {
                case "BR": pb.Image = Properties.Resources.dinoverde; break;
                case "AZ": pb.Image = Properties.Resources.dinoazul; break;
                case "AM": pb.Image = Properties.Resources.dinoamarelo; break;
                case "EP": pb.Image = Properties.Resources.dinorosa; break;
                default:
                    MessageBox.Show("Dino inválido");
                    return;
            }

            //CERCADO
            Panel destino = null;
            switch (cercado.ToUpper())
            {
                case "FI": destino = panelFI; break;
                case "PA": destino = panelPA; break;
                case "IS": destino = panelIS; break;
                case "MT": destino = panelMT; break;
                case "CD": destino = panelCD; break;
                case "RS": destino = panelRS; break;
                default: destino = null; break;
                    MessageBox.Show("Cercado inválido! Use FI, PA, IS, MT, CD ou RS");
                    return;
            }

            // Número de slots por cercado
            int numSlots = 0;
            switch (cercado.ToUpper())
            {
                case "FI": numSlots = 6; break;
                case "PA": numSlots = 5; break;
                case "IS": numSlots = 5; break;
                case "MT": numSlots = 4; break;
                case "CD": numSlots = 3; break;
                case "RS": numSlots = 4; break;
            }

            //////- ESSA PARTE NAO ESTA 100% AINDA
           

            // Calcula posições centralizadas para cada slot
            Point[] posicoes = new Point[numSlots];
            int y = 10; // linha constante
            int slotWidth = destino.Width / numSlots; // ISSO DEVIDE O CERCADO EM PARTES IGUAIS

            for (int i = 0; i < numSlots; i++)
            {
                int x = i * slotWidth + (slotWidth - dinoSize) / 2;
                posicoes[i] = new Point(x, y);
            }

            // Verifica se ainda cabe mais dinos
            int index = destino.Controls.Count;
            if (index >= posicoes.Length)
            {
                MessageBox.Show("Cercado cheio!");
                return;
            }

            // Coloca o dino na posição correta
            pb.Left = posicoes[index].X;
            pb.Top = posicoes[index].Y;


            ////////
            
            // Adiciona ao painel
            destino.Controls.Add(pb);
            destino.Refresh();


        }

        private void pbTabuleiro_Click(object sender, EventArgs e)
        {
        }
        private void panelIS_Paint(object sender, PaintEventArgs e)
        {
        }
        private void panelFI_Paint(object sender, PaintEventArgs e)
        {
        }
        private void lblTurno_Click(object sender, EventArgs e)
        {
        }



        //BUTTON JOGAR
        private void btnJogarManual_Click(object sender, EventArgs e)
        {
            string dino = cmbDino.SelectedItem?.ToString();
            string cercado = cmbCercado.SelectedItem?.ToString();


            if (dino == null || cercado == null)
            {
                MessageBox.Show("Selecione dino e cercado!");
                return;
            }


            AdicionarDino(dino, cercado);
            //  REMOVE DA MÃO
            maoAtual = maoAtual.Replace(dino + ",1", "");

            lblMao.Text = "Mão:\n" + maoAtual;
        }

       
    }
}
