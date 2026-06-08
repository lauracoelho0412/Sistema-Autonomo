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
        private Random random = new Random();

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

            this.WindowState = FormWindowState.Maximized;
            this.Scale(new SizeF(1.5f, 1.5f));

        }

        public void IniciarAutomacao()
        
        {
            timer1.Start();
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
            AjustarLayout();

        }

        private void AjustarLayout()
        {
            int larguraMetade = this.ClientSize.Width / 2;

            panelTabu.Left = 0;
            panelTabu.Top = 0;
            panelTabu.Width = larguraMetade;
            panelTabu.Height = this.ClientSize.Height;

            panel1HUD.Left = larguraMetade;
            panel1HUD.Top = 0;
            panel1HUD.Width = larguraMetade;
            panel1HUD.Height = this.ClientSize.Height;
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
            if (_jogador == null)
                _jogador = new Jogador();

            if (_partida == null)
                _partida = new Partida();

            _jogador.Nome = nomeJogador;
            _jogador.Senha = senha;
            _jogador.Id = idJogador;
            _partida.Id = idPartida;

            lblJogador.Text = "Jogador:\n " + nomeJogador;

            string retorno = Jogo.VerificarPartida(_partida.Id);

            if (_turno == null)
                _turno = new Turno();

            if (!_partida.CarregarDeVerificacao(retorno, _turno))
            {
                lblStatus.Text = "Aguardando partida iniciar";
                MostrarErro(retorno);
                return;
            }

            _partida.Jogadores = Jogador.ListarJogadores(_partida.Id);
            _jogador.Mao = ObterMaoJogador();

            AtualizarLabels();
            timer1.Start();
        }

        private List<Dinossauro> ObterMaoJogador()
        {
            string retorno = Jogo.ExibirMao(_jogador.Id, _jogador.Senha);

            if (retorno.Contains("ERRO"))
            {
                return new List<Dinossauro>();
            }

            return Dinossauro.ListarDinossauros(retorno);
        }

        #endregion

        #region Atualização de UI

        private void AtualizarLabels()
        {
            lblDado.Text = "Dado:\n " + _turno.Dado;
            lblTurno.Text = "Turno:\n " + _turno.TurnoAtual;
            lblJogadorDado.Text = "Jogador com o dado:\n " + ObterNomeJogadorDado();

            AtualizarLabelMao();
        }

        private void AtualizarLabelMao()
        {
            lblMao.Text = "Minha Mão:\n" + string.Join("\n",
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
                case "Br": return Properties.Resources.dinoroxo;
                case "Pa": return Properties.Resources.dinoverde;
                case "Et": return Properties.Resources.dinoazul;
                case "Ep": return Properties.Resources.dinolaranja;
                case "Ti": return Properties.Resources.dinovermelho;
                case "Tr": return Properties.Resources.dinoamarelo;
                default: return null;
            }
        }

        #endregion

        #region Lógica de Jogo

        /// <summary>
        /// Valida se a jogada é permitida com base no dado atual e em quem possui o dado.
        /// </summary>
        private bool ValidarJogada(string dino, string cercado)
        {
            bool ehJogadorDoDado = _jogador.Id == _turno.IdJogadorDado;

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

        private void VerificarGanhador()
        {
            var jogadores = Jogador.ListarJogadores(_partida.Id);
            var maxPontos = jogadores.Max(j => j.Pontuacao);
            var ganhadores = jogadores.Where(j => j.Pontuacao == maxPontos).ToList();
            var jogadoresTexto = string.Join("\n", jogadores.Select(j => $"{j.Nome}: {j.Pontuacao} pontos"));
            if (ganhadores.Count == 1)
                MessageBox.Show($"Partida Finalizada!\n" +
                    $"O ganhador é {ganhadores[0].Nome} com {maxPontos} pontos!" +
                    $"\n\nPontuação dos jogadores:\n{jogadoresTexto}");
            else
                MessageBox.Show($"Partida Finalizada!\n" +
                    $"Empate entre: {string.Join(", ", ganhadores.Select(g => g.Nome))} com {maxPontos} pontos cada!" +
                    $"\n\nPontuação dos jogadores:\n{jogadoresTexto}");
        }

        #endregion

        #region Regras do Dado e Cercados

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

        private bool AdicionarDino(string nomeDino, string cercado)
        {

            string retorno = Jogo.Jogar(_jogador.Id, _jogador.Senha, nomeDino, cercado);

            if (retorno.Contains("ERRO"))
            {
                return false;
            }

            Panel destino = ObterPainelDoCercado(cercado);
            if (destino == null) return false;

            int slots = SlotsPorCercado[cercado];
            int dinosNoPanel = destino.Controls.OfType<PictureBox>().Count();

            if (dinosNoPanel >= slots) return false;

            Image imagem = ObterImagemDino(nomeDino);
            if (imagem == null) return false;

            PictureBox pb = CriarPictureBoxDino(imagem, destino, slots, dinosNoPanel);

            var lista = _cercados[cercado];
            var existente = lista.FirstOrDefault(d => d.Nome == nomeDino);

            if (existente != null)
                existente.Quantidade++;
            else
                lista.Add(new Dinossauro { Nome = nomeDino, Quantidade = 1 });

            destino.Controls.Add(pb);
            pb.BringToFront();
            destino.Refresh();

            return true;
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

            if (string.IsNullOrWhiteSpace(retorno) || retorno.Contains("ERRO"))
            {
                return;
            }

            retorno = retorno.Replace("\r", "");

            string[] linhas = retorno.Split('\n');
            if (linhas.Length == 0)
                return;

            string primeiraLinha = linhas[0];

            _turno.CarregarDeCsv(primeiraLinha);

            _jogador.Mao = ObterMaoJogador();

            AtualizarLabels();
           

            string tabuleiro = Jogo.ExibirTabuleiro(_jogador.Id, _jogador.Senha);
            lblCercados.Text = "Situação do Tabuleiro:\n" + tabuleiro;
            lblStatus.Text = "Turno OK";

            if (_turno.Status == "F")
                _turno.TurnoAtual++;
        }

        #endregion

        #region Helpers

        private void MostrarErro(string mensagem) =>
            MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);

        #endregion

        //FORÇANDO A RODAR UM TURNO
        private int ultimoTurnoJogada = -1;

        // Controla se já reservamos um dino para a Ilha Solitária
        private bool _ilhaSolitariaReservada = false;

        //TIMER

        private void timer1_Tick(object sender, EventArgs e)
        {
            btnAtualizar_Click(null, null);

            if (_turno.TurnoAtual > 12)
            {
                timer1.Stop();
                VerificarGanhador();
                return;
            }

            // Não jogar duas vezes no mesmo turno
            if (_turno.TurnoAtual == ultimoTurnoJogada)
                return;

            if (_jogador.Mao == null || _jogador.Mao.Count == 0)
                return;

            var jogada = EscolherJogada();

            if (jogada.HasValue)
            {
                bool jogou = AdicionarDino(jogada.Value.dino, jogada.Value.cercado);
                if (jogou)
                {
                    AtualizarLabelMao();
                    ultimoTurnoJogada = _turno.TurnoAtual;
                    lblStatus.Text = $"Estratégia: {jogada.Value.dino} → {jogada.Value.cercado}";
                    return;
                }
            }

            // Fallback: qualquer jogada válida para não travar
            var disponiveis = _jogador.Mao.Where(d => d.Quantidade > 0).ToList();
            foreach (var dino in disponiveis)
            {
                foreach (var cercado in new[] { "CD", "MT", "RS", "IS", "PA", "RI", "FI" })
                {
                    if (AdicionarDino(dino.Nome, cercado))
                    {
                        AtualizarLabelMao();
                        ultimoTurnoJogada = _turno.TurnoAtual;
                        lblStatus.Text = $"Fallback: {dino.Nome} → {cercado}";
                        return;
                    }
                }
            }

            // Nenhuma jogada possível — avança o controle de turno
            ultimoTurnoJogada = _turno.TurnoAtual;
        }

        /// Prioridades:
        ///   1. Campina da Diferença (CD) — baixo risco, maioria dos dinos
        ///   2. Mata Tripla (MT)          — baixo risco, 2ª prioridade
        ///   3. Rei da Selva (RS)         — médio risco, só se já tem ≥2 dinos da mesma cor
        ///   4. Ilha Solitária (IS)       — reservar 1 dino único para ela
        ///   5. Floresta da Igualdade (FI)— alto risco, evitar
        ///   T-Rex: evitar na Campina se CD tiver menos de 4; preferir MT para T-Rex
        
        private (string dino, string cercado)? EscolherJogada()
        {
            var mao = _jogador.Mao.Where(d => d.Quantidade > 0).ToList();
            if (mao.Count == 0) return null;

            // Separa T-Rex dos demais
            var trex = mao.FirstOrDefault(d => d.Nome == "Ti");
            var semTrex = mao.Where(d => d.Nome != "Ti").ToList();
            int cdPreenchida = _cercados["CD"].Sum(d => d.Quantidade);
            int mtPreenchida = _cercados["MT"].Sum(d => d.Quantidade);

            // ── Prioridade 1: Campina da Diferença (CD) ──────────────────────────────
            foreach (var dino in semTrex)
            {
                // CD aceita apenas cores diferentes das já presentes
                bool corNovaParaCD = !_cercados["CD"].Any(d => d.Nome == dino.Nome);
                bool reservarParaIS = !_ilhaSolitariaReservada
                    && _cercados["IS"].Count == 0
                    && mao.Count(d => d.Nome == dino.Nome) == 1
                    && !_cercados.Any(kv => kv.Key != "IS" && kv.Value.Any(d => d.Nome == dino.Nome));

                if (corNovaParaCD && !reservarParaIS && ValidarJogada(dino.Nome, "CD"))
                    return (dino.Nome, "CD");
            }

            // ── Prioridade 2: Mata Tripla (MT) ───────────────────────────────────────
            if (mtPreenchida < 3)
            {
                if (trex != null && ValidarJogada(trex.Nome, "MT"))
                    return (trex.Nome, "MT");

                foreach (var dino in semTrex)
                {
                    if (ValidarJogada(dino.Nome, "MT"))
                        return (dino.Nome, "MT");
                }
            }

            // ── Prioridade 3: Rei da Selva (RS) ──────────────────────────────────────
            if (_cercados["RS"].Count == 0)
            {
                foreach (var dino in semTrex)
                {
                    int totalDessaCor = _cercados.Values
                        .SelectMany(c => c)
                        .Where(d => d.Nome == dino.Nome)
                        .Sum(d => d.Quantidade)
                        + mao.Where(d => d.Nome == dino.Nome).Sum(d => d.Quantidade);

                    if (totalDessaCor >= 2 && ValidarJogada(dino.Nome, "RS"))
                        return (dino.Nome, "RS");
                }
            }

            // ── Prioridade 4: Ilha Solitária (IS) ────────────────────────────────────
            if (_cercados["IS"].Count == 0)
            {
                foreach (var dino in semTrex)
                {
                    bool unicoNoZoo = !_cercados.Any(kv => kv.Value.Any(d => d.Nome == dino.Nome));
                    if (unicoNoZoo && ValidarJogada(dino.Nome, "IS"))
                    {
                        _ilhaSolitariaReservada = true;
                        return (dino.Nome, "IS");
                    }
                }
            }

            // ── T-Rex: fallback estratégico ───────────────────────────────────────────
            if (trex != null)
            {
                if (cdPreenchida >= 4 && ValidarJogada(trex.Nome, "CD"))
                    return (trex.Nome, "CD");
                if (ValidarJogada(trex.Nome, "MT"))
                    return (trex.Nome, "MT");
                if (ValidarJogada(trex.Nome, "RI"))
                    return (trex.Nome, "RI");
            }

            // ── Floresta da Igualdade (FI) — último recurso entre os cercados ────────
            foreach (var dino in semTrex)
            {
                bool fiJaTemEssaCor = _cercados["FI"].Any(d => d.Nome == dino.Nome);
                bool fiVazia = _cercados["FI"].Count == 0;

                // Só investe em FI se já há maioria garantida (≥ 2 disponíveis desta cor)
                int totalDessaCor = mao.Where(d => d.Nome == dino.Nome).Sum(d => d.Quantidade);
                if ((fiVazia || fiJaTemEssaCor) && totalDessaCor >= 2 && ValidarJogada(dino.Nome, "FI"))
                    return (dino.Nome, "FI");
            }

            // ── Rio (RI): destino seguro quando nada mais é válido ────────────────────
            foreach (var dino in mao)
            {
                if (ValidarJogada(dino.Nome, "RI"))
                    return (dino.Nome, "RI");
            }

            return null;
        }


    }
}