using GestaoEquipamentos.WinFormsApp.ModuloEquipamentos;

namespace GestaoEquipamentos.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private EquipamentosController equipamentosController;

        public TelaPrincipalForm()
        {
            InitializeComponent();
            equipamentosController = new EquipamentosController();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEquipamentos_Click(object sender, EventArgs e)
        {
            this.panelListControl.Controls.Clear();
            //this.baseControllerAtual = this.equipamentosController;
            this.panelListControl.Controls.Add(equipamentosController.View);
        }
    }
}
