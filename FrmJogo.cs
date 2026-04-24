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
    public partial class FrmJogo : Form
    {
        private List<Dinossauro> maoAtual;
        private Turno _turno;
        private Jogador _jogador;
        private Partida _partida;

        public FrmJogo()
        {
            InitializeComponent();
            _turno = new Turno();
            _jogador = new Jogador();
            _partida = new Partida();
        }

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
        public void AtualizarInfoTurno(string jogador, int jogadorID, string senha, int partidaID)
        {
            _jogador.Nome = jogador;
            _jogador.Senha = senha;
            _jogador.Id = jogadorID;
            _partida.Id = partidaID;

            lblJogador.Text = "Jogador: " + jogador;

            string retorno = Jogo.VerificarPartida(_partida.Id);
            if (retorno.Contains("ERRO"))
            {
                MessageBox.Show(retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                string[] infoPartida = retorno.Split(',');
                _partida.Status = infoPartida[0];
                _turno.TurnoAtual = Convert.ToInt32(infoPartida[1]);
                _turno.Status = infoPartida[2];
                _turno.IdJogadorDado = Convert.ToInt32(infoPartida[3]);
                _turno.Dado = infoPartida[4];
            }

            lblDado.Text = "Dado: " + _turno.Dado;
            lblTurno.Text = "Turno: " + _turno.TurnoAtual;
            lblJogadorDado.Text = "Jogador com o dado: " + ObterNomeJogadorDado(_partida.Id);
            List<Dinossauro> listaDino = ObterMaoJogador();
            lblMao.Text = "Mão: \n" + string.Join("\n", listaDino.Select(d => $"{d.Nome} - Qtd:{d.Quantidade}")); ;

        }
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

        private List<Dinossauro> ObterMaoJogador()
        {
            string retorno = Jogo.ExibirMao(_jogador.Id, _jogador.Senha);
            if (retorno.Contains("ERRO"))
            {
                MessageBox.Show(retorno, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return new List<Dinossauro>();
            }
            else
            {
                List<Dinossauro> mao = Dinossauro.ListarDinossauros(retorno);
                return mao;
            }
        }


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
                return;
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

            // CERCADO destino
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
                    MessageBox.Show("Cercado inválido!");
                    return;
            }

            // Conta apenas PictureBoxes já adicionados (ignora outros controls)
            int dinosNoPanel = destino.Controls.OfType<PictureBox>().Count();

            if (dinosNoPanel >= numSlots)
            {
                MessageBox.Show("Cercado cheio!");
                return;
            }

            // Tamanho do dino baseado no panel — ocupa bem o espaço disponível
            int colunas = numSlots;
            int linhas = 1;

            // Se tiver 6 slots, usa 2 linhas de 3 para ficar melhor visualmente
            if (numSlots == 6)
            {
                colunas = 3;
                linhas = 2;
            }

            int padding = 4;
            int dinoW = (destino.Width - padding * (colunas + 1)) / colunas;
            int dinoH = (destino.Height - padding * (linhas + 1)) / linhas;
            int dinoSize = Math.Min(dinoW, dinoH); // quadrado, mantém proporção

            // Calcula posição (linha/coluna) baseado em quantos já existem
            int col = dinosNoPanel % colunas;
            int row = dinosNoPanel / colunas;

            int x = padding + col * (dinoSize + padding);
            int y = padding + row * (dinoSize + padding);

            // Cria o PictureBox
            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Width = dinoSize;
            pb.Height = dinoSize;
            pb.Left = x;
            pb.Top = y;
            pb.BackColor = Color.Transparent;

            // Imagem do dino
            switch (nomeDino)
            {
                case "Br": pb.Image = Properties.Resources.dinoverde; break;
                case "Pa": pb.Image = Properties.Resources.dinoverde; break;
                case "Et": pb.Image = Properties.Resources.dinoazul; break;
                case "Ep": pb.Image = Properties.Resources.dinolaranja; break;
                case "Ti": pb.Image = Properties.Resources.dinolaranja; break;
                case "Tr": pb.Image = Properties.Resources.dinoamarelo; break;
                default:
                    MessageBox.Show("Dino inválido!");
                    return;
            }

            // Atualiza dicionário de controle
            var lista = cercados[cercado.ToUpper()];
            var existente = lista.FirstOrDefault(d => d.Nome == nomeDino);
            if (existente != null)
                existente.Quantidade += 1;
            else
                lista.Add(new Dinossauro { Nome = nomeDino, Quantidade = 1 });

            destino.Controls.Add(pb);
            pb.BringToFront();
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
