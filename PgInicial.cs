using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Autonomo_Predadores
{
    public partial class PgInicial : Form
    {
        public PgInicial()
        {
            InitializeComponent();
        }

        private void btnLobby_Click(object sender, EventArgs e)
        {
            Lobby lobby = new Lobby();
            lobby.ShowDialog();
        }
    }
}
