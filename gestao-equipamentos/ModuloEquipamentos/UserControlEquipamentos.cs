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
    }
}
