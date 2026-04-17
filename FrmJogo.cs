using Draft;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
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
        private List<Dinossauro> maoAtual;
        private Turno _turno;
        private Jogador _jogador;

        public FrmJogo()
        {
            InitializeComponent();
            _turno = new Turno();
            _jogador = new Jogador();
        }




        //tira o fundo branco dos panel INDIVIDUAL
        private void FrmJogo_Load(object sender, EventArgs e)
        {
            panelFI.Parent = panelTabu;
            panelFI.BackColor = Color.Transparent;

            panelCD.Parent = panelTabu;
            panelCD.BackColor = Color.Transparent;

            panelRI.Parent = panelTabu;
            panelRI.BackColor = Color.Transparent;

            panelMT.Parent = panelTabu;
            panelMT.BackColor = Color.Transparent;

            panelPA.Parent = panelTabu;
            panelPA.BackColor = Color.Transparent;

            panelIS.Parent = panelTabu;
            panelIS.BackColor = Color.Transparent;

            panelRS.Parent = panelTabu;
            panelRS.BackColor = Color.Transparent;


            this.DoubleBuffered = true; // evita flicker
          this.Refresh();

        }   


        //ATUALIZA A PRIMEIRA ENTRADA DO JOGO
        public void AtualizarInfoTurno(string jogador, int jogadorID, string senha, int jogadorDado, string dado, int turno, List<Dinossauro> listaDino, List<Jogador> listaJoga)
        {
            lblJogadorDado.Text = "Jogador: " + jogador;
            lblDado.Text = "Dado: " + dado;
            lblTurno.Text = "Turno: " + turno;
            lblMao.Text = "Mão: \n" + string.Join("\n", listaDino.Select(d => $"{d.Nome} - Qtd:{d.Quantidade}")); ;
            _turno.Dado = dado;
            _turno.TurnoAtual = turno;
            _turno.IdJogadorDado = jogadorDado;
            _turno.listaJogadores = listaJoga;

            foreach (Jogador j in listaJoga)
            {
                if (j.Id == jogadorDado)
                {
                    lblJDado.Text = "Jogador com dado:" + j.Nome;
                    break;
                }
            }

            _jogador.Nome = jogador;
            _jogador.Senha = senha;
            _jogador.Id = jogadorID;

            maoAtual = listaDino; // salva a mão
        }


        //RECEBE
        /*public void ReceberJogada(string dino, string cercado)
        {
            AdicionarDino(dino, cercado);
        }
        */

        //PRINCIPAL - ADICIONAR
        private Dictionary<string, List<Dinossauro>> cercados = new Dictionary<string, List<Dinossauro>>()
        {
             { "FI", new List<Dinossauro>() },
             { "PA", new List<Dinossauro>() },
             { "IS", new List<Dinossauro>() },
             { "MT", new List<Dinossauro>() },
             { "CD", new List<Dinossauro>() },
             { "RS", new List<Dinossauro>() },
             { "RI", new List<Dinossauro>() }
        };
        private void AdicionarDino(string nomeDino, string cercado)
        {
           string retorno = Jogo.Jogar(_jogador.Id, _jogador.Senha, nomeDino, cercado);
            if (retorno.Contains("ERRO"))
            {
                MessageBox.Show(retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                _turno.TurnoAtual = Convert.ToInt32(retorno);
            }

            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.Zoom;


            // Declare a variável dinoSize ANTES de usar
            int dinoSize = 80; 
            pb.Width = dinoSize;
            pb.Height = dinoSize;


            //  dino
            switch (nomeDino)
            {
                case "Br": pb.Image = Properties.Resources.dinoverde; break;
                case "Pa": pb.Image = Properties.Resources.dinoverde; break;
                case "Et": pb.Image = Properties.Resources.dinoazul; break;
                case "Ep": pb.Image = Properties.Resources.dinolaranja; break;
                case "Ti": pb.Image = Properties.Resources.dinolaranja; break;
                case "Tr": pb.Image = Properties.Resources.dinoamarelo; break;
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
                case "RI": destino = panelRI; break;
                default:
                    MessageBox.Show("Cercado inválido! Use FI, PA, IS, MT, CD ou RS");
                        break;

            }

            // Número de slots por cercado
            int numSlots = 0;
            switch (cercado.ToUpper())
            {
                case "FI": numSlots = 6; break;
                case "PA": numSlots = 6; break;
                case "IS": numSlots = 1; break;
                case "MT": numSlots = 3; break;
                case "CD": numSlots = 6; break;
                case "RS": numSlots = 1; break;
                case "RI": numSlots = 6; break;
            }

           

            // Calcula posições centralizadas para cada slot
            Point[] posicoes = new Point[numSlots];
            int y = 10; // linha constante
            int slotWidth = Math.Max(dinoSize + 10, destino.Width / numSlots);

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

            var lista = cercados[cercado.ToUpper()];
            var existente = lista.FirstOrDefault(d => d.Nome == nomeDino);

            if (existente != null)
            {
                existente.Quantidade += 1; // já atualiza direto pois é referência
            }
            else
            {
                lista.Add(new Dinossauro { Nome = nomeDino, Quantidade = 1 });
            }

            // Adiciona ao painel
            destino.Controls.Add(pb);
            destino.Refresh();


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

            bool podeAdd = false;

            if(maoAtual.Any(d => d.Nome == dino))
            {
                switch (_turno.Dado)
                {
                    case "AL": if (cercado.ToUpper() == "FI" && !cercados["FI"].Any(d => d.Nome == dino) || cercado.ToUpper() == "FI" && cercados["FI"].Count == 0 || cercado == "MT" || cercado == "PA") podeAdd = true; break;
                    case "FL": if (cercado.ToUpper() == "FI" && cercados["FI"].Any(d => d.Nome == dino) || cercado.ToUpper() == "FI" && cercados["FI"].Count == 0 || cercado == "MT" || cercado == "RS") podeAdd = true; break;
                    case "PR": if (cercado.ToUpper() == "CD" && cercados["CD"].Any(d => d.Nome == dino) || cercado.ToUpper() == "CD" && cercados["CD"].Count == 0 || cercado == "PA" || cercado == "IS") podeAdd = true; break;
                    case "TI": if (!cercados[cercado].Any(d => d.Nome == "Ti"))podeAdd = true; break;
                    case "VZ": if(cercados[cercado].Count == 0) podeAdd = true; break;
                    case "WC": if (cercado.ToUpper() == "CD" && cercados["CD"].Any(d => d.Nome == dino) || cercado.ToUpper() == "CD" && cercados["CD"].Count == 0 || cercado == "RS" || cercado == "IS") podeAdd = true; break;
                }
            }
            else
            {
                MessageBox.Show("Você não tem esse dino na mão!");
                return;
            }

            if (podeAdd)
            {
                AdicionarDino(dino, cercado);
            }
            else
            {
                MessageBox.Show("Jogada inválida! Verifique o dado e os cercados permitidos.");
                return;
            }

                //  REMOVE DA MÃO
            var dinoUsado = maoAtual.FirstOrDefault(d => d.Nome == dino);
            if (dinoUsado != null)
            {
                dinoUsado.Quantidade -= 1;
                if (dinoUsado.Quantidade <= 0)
                    maoAtual.Remove(dinoUsado);
            }

            lblMao.Text = "Mão:\n" + string.Join("\n", maoAtual.Select(d => $"{d.Nome} - Qtd:{d.Quantidade}")); ;
        }

    }
}
