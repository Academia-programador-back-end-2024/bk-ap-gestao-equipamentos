namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamentos
{
    public partial class UserControlEquipamentos : UserControl
    {
        private EquipamentosController equipamentosController;
        public UserControlEquipamentos(EquipamentosController equipamentosController)
        {
            InitializeComponent();
            this.equipamentosController = equipamentosController;
            AtualizarGrid();
        }

        private void AtualizarGrid()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = equipamentosController.ObterEquipamentos();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equipamentosController.MostrarViewFormEquipamento();
            AtualizarGrid();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is EquipamentoModel equipamentoModel)
            {
                equipamentosController.MostrarViewFormEquipamento(equipamentoModel);
                AtualizarGrid();
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is EquipamentoModel equipamentoModel)
            {
                equipamentosController.MostrarViewFormDeleteEquipamento(equipamentoModel);
                AtualizarGrid();
            }
        }
    }
}
