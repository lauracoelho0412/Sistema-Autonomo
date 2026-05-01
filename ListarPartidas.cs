using System.Windows.Forms;

namespace Sistema_Autonomo_Predadores
{
    public partial class ListarPartidas : Form
    {
        internal Partida PartidaSelecionada { get; private set; }

        public ListarPartidas()
        {
            InitializeComponent();
            CarregarPartidasNaTabela();
        }

        private void CarregarPartidasNaTabela()
        {
            dgvListarPartidas.DataSource = Partida.ListarPartidas();

            dgvListarPartidas.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvListarPartidas.EditMode = DataGridViewEditMode.EditProgrammatically;
            dgvListarPartidas.AllowUserToResizeColumns = false;
            dgvListarPartidas.AllowUserToResizeRows = false;
            dgvListarPartidas.RowHeadersVisible = false;

            dgvListarPartidas.Columns[0].Visible = false;
            dgvListarPartidas.Columns[1].HeaderText = "Nome da Partida";
            dgvListarPartidas.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
        }

        private void btnSelecionar_Click(object sender, System.EventArgs e)
        {
            if (dgvListarPartidas.SelectedRows.Count == 0) return;
            PartidaSelecionada = (Partida)dgvListarPartidas.SelectedRows[0].DataBoundItem;
            this.Close();
        }
    }
}