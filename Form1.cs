using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Draft;

namespace Sistema_Autonomo_Predadores
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            lblVersao.Text = "Versão: " + Jogo.versao;
            cboGrupo.Items.Add("Raptores");
            cboGrupo.Items.Add("Jurássicos");
            cboGrupo.Items.Add("Carnívoros");
            cboGrupo.Items.Add("Terópodes");
            cboGrupo.Items.Add("Predadores");
            cboGrupo.Items.Add("Fossilizados");
            cboGrupo.Items.Add("Tricerátops");
            cboGrupo.Items.Add("Espinossauros");
            cboGrupo.Items.Add("Dominantes");
            cboGrupo.Items.Add("Colossais");
            cboGrupo.Items.Add("Gigantes");
            cboGrupo.Items.Add("Sobreviventes");
            cboGrupo.Items.Add("Extintos");
            cboGrupo.Items.Add("Saurianos");
            cboGrupo.Items.Add("Primordiais");
            cboGrupo.Items.Add("Braquiossauros");
            cboGrupo.Items.Add("Naturalistas");
            cboGrupo.Items.Add("Paleontólogos");
            cboGrupo.Items.Add("Escavadores");
            cboGrupo.Items.Add("Mesozóicos");
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
            Jogo.CriarPartida(mtbNome.Text, mtbSenha.Text, cboGrupo.SelectedItem.ToString());
            if (mtbNome.Text == "" || mtbSenha.Text == "")
            {
                MessageBox.Show("Algum campo não foi preenchido!", "atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                MessageBox.Show("Partida criada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
