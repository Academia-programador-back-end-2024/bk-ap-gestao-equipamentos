using GestaoEquipamentos.WinFormsApp.ModuloEquipamentos;

namespace WinFormsApp1
{
    public partial class GestaoEquipamentosForm : Form
    {
        private EquipamentosController equipamentosController { get; set; }
        public GestaoEquipamentosForm()
        {
            InitializeComponent();
            equipamentosController = new EquipamentosController();
            AtualizarGrid();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equipamentosController.AdicionarEquipamento();
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = equipamentosController.ObterEquipamentos();
        }
    }
}
