using GestaoEquipamentos.WinFormsApp.ModuloCSV;
using GestaoEquipamentos.WinFormsApp.ModuloEquipamentos;
using GestaoEquipamentos.WinFormsApp.ModuloFabricantes;
using GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento;

namespace GestaoEquipamentos.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private EquipamentosController equipamentosController { get; set; }
        private TipoDeEquipamentoController tipoDeEquipamentoController { get; set; }

        private FabricanteController fabricanteController { get; set; }
        private CsvController csvController { get; set; }


        public TelaPrincipalForm()
        {
            InitializeComponent();
            equipamentosController = new EquipamentosController();
            tipoDeEquipamentoController = new TipoDeEquipamentoController();

            var _repositorioFabricanteSemContrato = new RepositorioFabricanteEmArquivo();

            //SOL "I" D 
            //IOC

            fabricanteController = new FabricanteController(
                _repositorioFabricanteSemContrato,
                _repositorioFabricanteSemContrato);

            csvController = new CsvController(
                equipamentosController,
                equipamentosController.ObterEquipamentos());
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
            equipamentosController.View.Atualizar();
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

        private void btnCSV_Click(object sender, EventArgs e)
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(csvController.View);
        }

        private void btnFabricantes_Click(object sender, EventArgs e)
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(fabricanteController.View);
        }
    }
}
