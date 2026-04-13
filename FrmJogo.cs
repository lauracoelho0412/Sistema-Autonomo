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
    public partial class FrmJogo : Form
    {

        public void ReceberJogada(string dino, string cercado)
        {
            AdicionarDino(dino, cercado);
        }
        public FrmJogo()
        {
            InitializeComponent();
        }

        private void FrmJogo_Load(object sender, EventArgs e)
        {

            AjustarTransparencia(this);


        }


        private void AdicionarDino(string nomeDino, string cercado)
        {
            PictureBox pb = new PictureBox();
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            pb.Width = 50;
            pb.Height = 50;

            //CONVERTE CODIGO → NOME DA COR
             nomeDino = nomeDino.ToUpper();

            switch (nomeDino)
            {
                case "BR": nomeDino = "VERDE"; break;
                case "EP": nomeDino = "ROSA"; break;
                case "AM": nomeDino = "AMARELO"; break;
                case "AZ": nomeDino = "AZUL"; break;
            }


            switch (nomeDino)
            {
                case "VERDE":
                    pb.Image = Properties.Resources.dinoverde;
                    break;

                case "AZUL":
                    pb.Image = Properties.Resources.dinoazul;
                    break;

                case "AMARELO":
                    pb.Image = Properties.Resources.dinoamarelo;
                    break;

                case "ROSA":
                    pb.Image = Properties.Resources.dinorosa;
                    break;

                default:
                    MessageBox.Show("Dino inválido");
                    return;
            }

            //CONVERTE CERCADO (SIGLA → NUMERO)
            cercado = cercado.ToUpper();

            switch (cercado)
            {
                case "FI": cercado = "1"; break;
                case "PA": cercado = "2"; break;
                case "IS": cercado = "3"; break;
                case "MT": cercado = "4"; break;
                case "CD": cercado = "5"; break;
                case "RS": cercado = "6"; break;
            }

            Panel destino = null;

            switch (cercado)
            {
                case "1": destino = panelFI; break;
                case "2": destino = panelPA; break;
                case "3": destino = panelIS; break;
                case "4": destino = panelMT; break;
                case "5": destino = panelCD; break;
                case "6": destino = panelRS; break;

                default:
                    MessageBox.Show("Cercado inválido");
                    return;
            }
            pb.Left = (destino.Controls.Count % 3) * 55;
            pb.Top = (destino.Controls.Count / 3) * 55;

            destino.Controls.Add(pb);
        
        }

        private void AjustarTransparencia(Control controle)
        {
            if (controle is Panel)
            {
                controle.Parent = pbTabuleiro;
                controle.BackColor = Color.Transparent;
            }

            foreach (Control filho in controle.Controls)
            {
                AjustarTransparencia(filho);
            }
        }
        private void pbTabuleiro_Click(object sender, EventArgs e)
        {
        }

        private void panelIS_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}
