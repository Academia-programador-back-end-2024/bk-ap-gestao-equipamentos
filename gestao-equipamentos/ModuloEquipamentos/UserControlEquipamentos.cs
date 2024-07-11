using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamentos
{
    public partial class UserControlEquipamentos : ViewUserControl
    {
        private EquipamentosController equipamentosController;
        public UserControlEquipamentos(EquipamentosController equipamentosController)
        {
            InitializeComponent();
            this.equipamentosController = equipamentosController;
            Atualizar();
        }

        public override void Atualizar()
        {
            this.dataGridView1.DataSource = null;
            this.dataGridView1.DataSource = equipamentosController.ObterEquipamentos();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            equipamentosController.MostrarViewFormEquipamento();
            Atualizar();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is EquipamentoModel equipamentoModel)
            {
                equipamentosController.MostrarViewFormEquipamento(equipamentoModel);
                Atualizar();
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows[0].DataBoundItem is EquipamentoModel equipamentoModel)
            {
                equipamentosController.MostrarViewFormDeleteEquipamento(equipamentoModel);
                Atualizar();
            }
        }
    }
}
