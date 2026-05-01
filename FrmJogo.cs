using Draft;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sistema_Autonomo_Predadores
{
    public partial class FrmJogo : Form
    {
        #region Campos

        private Turno _turno;
        private Jogador _jogador;
        private Partida _partida;

        // Número máximo de slots por cercado
        private static readonly Dictionary<string, int> SlotsPorCercado = new Dictionary<string, int>
        {
            { "FI", 6 }, { "PA", 6 }, { "CD", 6 }, { "RI", 6 },
            { "MT", 3 },
            { "IS", 1 }, { "RS", 1 }
        };

        // Controle dos dinossauros presentes em cada cercado
        private readonly Dictionary<string, List<Dinossauro>> _cercados = new Dictionary<string, List<Dinossauro>>
        {
            { "FI", new List<Dinossauro>() }, { "PA", new List<Dinossauro>() },
            { "IS", new List<Dinossauro>() }, { "MT", new List<Dinossauro>() },
            { "CD", new List<Dinossauro>() }, { "RS", new List<Dinossauro>() },
            { "RI", new List<Dinossauro>() }
        };

        #endregion

        #region Inicialização

        public FrmJogo()
        {
            InitializeComponent();
            _turno = new Turno();
            _jogador = new Jogador();
            _partida = new Partida();
        }

        private void FrmJogo_Load(object sender, EventArgs e)
        {
            ConfigurarPainelTransparente(panelFI);
            ConfigurarPainelTransparente(panelCD);
            ConfigurarPainelTransparente(panelRI);
            ConfigurarPainelTransparente(panelMT);
            ConfigurarPainelTransparente(panelPA);
            ConfigurarPainelTransparente(panelIS);
            ConfigurarPainelTransparente(panelRS);

            this.DoubleBuffered = true;
            this.Refresh();
        }

        private void ConfigurarPainelTransparente(Panel painel)
        {
            painel.Parent = panelTabu;
            painel.BackColor = Color.Transparent;
        }

        #endregion

        #region Carregamento de Dados

        /// <summary>
        /// Ponto de entrada chamado pelo Lobby ao abrir a tela de jogo.
        /// </summary>
        public void AtualizarInfoTurno(string nomeJogador, int idJogador, string senha, int idPartida)
        {
            _jogador.Nome = nomeJogador;
            _jogador.Senha = senha;
            _jogador.Id = idJogador;
            _partida.Id = idPartida;

            lblJogador.Text = "Jogador: " + nomeJogador;

            string retorno = Jogo.VerificarPartida(_partida.Id);

            if (!_partida.CarregarDeVerificacao(retorno, _turno))
            {
                MostrarErro(retorno);
                return;
            }

            _partida.Jogadores = Jogador.ListarJogadores(_partida.Id);
            _jogador.Mao = ObterMaoJogador();

            AtualizarLabels();
        }

        private List<Dinossauro> ObterMaoJogador()
        {
            string retorno = Jogo.ExibirMao(_jogador.Id, _jogador.Senha);

            if (retorno.Contains("ERRO"))
            {
                MostrarErro(retorno);
                return new List<Dinossauro>();
            }

            return Dinossauro.ListarDinossauros(retorno);
        }

        #endregion

        #region Atualização de UI

        private void AtualizarLabels()
        {
            lblDado.Text = "Dado: " + _turno.Dado;
            lblTurno.Text = "Turno: " + _turno.TurnoAtual;
            lblJogadorDado.Text = "Jogador com o dado: " + ObterNomeJogadorDado();
            lblStatus.Text = "Status: " + _turno.Status;
            AtualizarLabelMao();
        }

        private void AtualizarLabelMao()
        {
            lblMao.Text = "Mão:\n" + string.Join("\n",
                _jogador.Mao.Select(d => $"{d.Nome} - Qtd:{d.Quantidade}"));
        }

        private string ObterNomeJogadorDado()
        {
            return _partida.Jogadores?
                .FirstOrDefault(j => j.Id == _turno.IdJogadorDado)?.Nome
                ?? "Jogador não encontrado!";
        }

        private Panel ObterPainelDoCercado(string cercado)
        {
            switch (cercado)
            {
                case "FI": return panelFI;
                case "PA": return panelPA;
                case "IS": return panelIS;
                case "MT": return panelMT;
                case "CD": return panelCD;
                case "RS": return panelRS;
                case "RI": return panelRI;
                default: return null;
            }
        }

        private Image ObterImagemDino(string nomeDino)
        {
            switch (nomeDino)
            {
                case "Br":
                case "Pa": return Properties.Resources.dinoverde;
                case "Et": return Properties.Resources.dinoazul;
                case "Ep":
                case "Ti": return Properties.Resources.dinolaranja;
                case "Tr": return Properties.Resources.dinoamarelo;
                default: return null;
            }
        }

        #endregion

        #region Lógica de Jogo

        private void btnJogarManual_Click(object sender, EventArgs e)
        {
            string dino = cmbDino.SelectedItem?.ToString();
            string cercado = cmbCercado.SelectedItem?.ToString();

            if (dino == null || cercado == null)
            {
                MessageBox.Show("Selecione dino e cercado!");
                return;
            }

            if (!_jogador.Mao.Any(d => d.Nome == dino))
            {
                MessageBox.Show("Você não tem esse dino na mão!");
                return;
            }

            if (!ValidarJogada(dino, cercado))
            {
                MessageBox.Show("Jogada inválida! Verifique o dado e os cercados permitidos.");
                return;
            }

            AdicionarDino(dino, cercado);
            RemoverDinoMao(dino);
            AtualizarLabelMao();
        }

        /// <summary>
        /// Valida se a jogada é permitida com base no dado atual e em quem possui o dado.
        /// </summary>
        private bool ValidarJogada(string dino, string cercado)
        {
            bool ehJogadorDoDado = _jogador.Nome == ObterNomeJogadorDado();

            if (ehJogadorDoDado)
                return RegraInternaDoCercado(_turno.Dado, cercado, dino);

            if (!CercadoLiberadoPeloDado(_turno.Dado, cercado))
                return false;

            // Regras especiais que dependem do estado interno do cercado
            if (_turno.Dado == "TI" && _cercados[cercado].Any(d => d.Nome == "Ti"))
                return false;

            if (_turno.Dado == "VZ" && _cercados[cercado].Count > 0)
                return false;

            return RegraInternaDoCercado(_turno.Dado, cercado, dino);
        }

        private void RemoverDinoMao(string nomeDino)
        {
            var dino = _jogador.Mao.FirstOrDefault(d => d.Nome == nomeDino);
            if (dino == null) return;

            dino.Quantidade--;
            if (dino.Quantidade <= 0)
                _jogador.Mao.Remove(dino);
        }

        #endregion

        #region Regras do Dado

        /// <summary>
        /// Verifica se o cercado está entre os permitidos para o dado atual.
        /// </summary>
        private bool CercadoLiberadoPeloDado(string dado, string cercado)
        {
            switch (dado)
            {
                case "AL": return cercado == "FI" || cercado == "MT" || cercado == "PA" || cercado == "RI";
                case "FL": return cercado == "FI" || cercado == "MT" || cercado == "RS" || cercado == "RI";
                case "PR": return cercado == "CD" || cercado == "PA" || cercado == "IS" || cercado == "RI";
                case "WC": return cercado == "CD" || cercado == "RS" || cercado == "IS" || cercado == "RI";
                case "TI": return true; // TI não restringe cercado — a restrição é interna (sem Ti no cercado)
                case "VZ": return true; // VZ não restringe cercado — a restrição é interna (cercado vazio)
                default: return false;
            }
        }

        /// <summary>
        /// Verifica as condições internas do cercado, independente do dado.
        /// </summary>
        private bool RegraInternaDoCercado(string dado, string cercado, string dino)
        {
            switch (cercado)
            {
                case "FI": return _cercados["FI"].Count == 0 || _cercados["FI"].Any(d => d.Nome == dino);
                case "MT": return _cercados["MT"].Count <= 3;
                case "PA": return true;
                case "RS": return true;
                case "CD": return _cercados["CD"].Count == 0 || !_cercados["CD"].Any(d => d.Nome == dino);
                case "IS": return _cercados["IS"].Count == 0;
                case "RI": return _cercados["RI"].Count == 0;
                default: return false;
            }
        }

        #endregion

        #region Renderização do Tabuleiro

        private void AdicionarDino(string nomeDino, string cercado)
        {
            string retorno = Jogo.Jogar(_jogador.Id, _jogador.Senha, nomeDino, cercado);
            if (retorno.Contains("ERRO"))
            {
                MostrarErro(retorno);
                return;
            }

            Panel destino = ObterPainelDoCercado(cercado);
            if (destino == null) { MessageBox.Show("Cercado inválido!"); return; }

            int slots = SlotsPorCercado[cercado];
            int dinosNoPanel = destino.Controls.OfType<PictureBox>().Count();

            if (dinosNoPanel >= slots) { MessageBox.Show("Cercado cheio!"); return; }

            Image imagem = ObterImagemDino(nomeDino);
            if (imagem == null) { MessageBox.Show("Dino inválido!"); return; }

            PictureBox pb = CriarPictureBoxDino(imagem, destino, slots, dinosNoPanel);

            // Atualiza controle interno
            var lista = _cercados[cercado];
            var existente = lista.FirstOrDefault(d => d.Nome == nomeDino);
            if (existente != null)
                existente.Quantidade++;
            else
                lista.Add(new Dinossauro { Nome = nomeDino, Quantidade = 1 });

            destino.Controls.Add(pb);
            pb.BringToFront();
            destino.Refresh();
        }

        private PictureBox CriarPictureBoxDino(Image imagem, Panel destino, int totalSlots, int dinosNoPanel)
        {
            int colunas = totalSlots == 6 ? 3 : totalSlots;
            int linhas = totalSlots == 6 ? 2 : 1;
            int padding = 4;

            int dinoW = (destino.Width - padding * (colunas + 1)) / colunas;
            int dinoH = (destino.Height - padding * (linhas + 1)) / linhas;
            int dinoSize = Math.Min(dinoW, dinoH);

            int col = dinosNoPanel % colunas;
            int row = dinosNoPanel / colunas;

            return new PictureBox
            {
                SizeMode = PictureBoxSizeMode.Zoom,
                Width = dinoSize,
                Height = dinoSize,
                Left = padding + col * (dinoSize + padding),
                Top = padding + row * (dinoSize + padding),
                BackColor = Color.Transparent,
                Image = imagem
            };
        }

        #endregion

        #region Botão Atualizar

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            string retorno = Jogo.VerificarTurno(_partida.Id, _turno.TurnoAtual);
            retorno = retorno.Replace("\r", "");

            string primeirLinha = retorno.Split('\n')[0];
            _turno.CarregarDeCsv(primeirLinha);

            _jogador.Mao = ObterMaoJogador();

            AtualizarLabels();

            string tabuleiro = Jogo.ExibirTabuleiro(_jogador.Id, _jogador.Senha);
            lblCercados.Text = tabuleiro;

            if (_turno.Status == "F")
                _turno.TurnoAtual++;
        }

        #endregion

        #region Helpers

        private void MostrarErro(string mensagem) =>
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        #endregion
    }
}