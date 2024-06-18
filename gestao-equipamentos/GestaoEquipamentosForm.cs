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

            this.dataGridView1.DataSource = equipamentosController.ObterEquipamentos();


        }
    }
}
