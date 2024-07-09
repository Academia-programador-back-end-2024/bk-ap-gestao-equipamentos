using GestaoEquipamentos.WinFormsApp.ModuloEquipamentos;
using GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento;

namespace GestaoEquipamentos.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private EquipamentosController equipamentosController { get; set; }
        private TipoDeEquipamentoController tipoDeEquipamentoController { get; set; }

        private TipoDeEquipamentoRepositorio _tipoDeEquipamentoRepositorio { get; set; }

        public TelaPrincipalForm()
        {
            InitializeComponent();
            _tipoDeEquipamentoRepositorio = new TipoDeEquipamentoRepositorio();
            equipamentosController = new EquipamentosController(_tipoDeEquipamentoRepositorio);
            tipoDeEquipamentoController = new TipoDeEquipamentoController(_tipoDeEquipamentoRepositorio);
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonEquipamentos_Click(object sender, EventArgs e)
        {
            Equipamentos();
        }

        private void Equipamentos()
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(equipamentosController.View);
        }

        private void equipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipamentos();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(tipoDeEquipamentoController.View);
        }

        private void TelaPrincipalForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            GC.Collect();
        }

    }
}
