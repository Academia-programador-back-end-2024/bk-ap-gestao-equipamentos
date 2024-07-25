using GestaoEquipamentos.WinFormsApp.ModuloClientes;
using GestaoEquipamentos.WinFormsApp.ModuloCSV;
using GestaoEquipamentos.WinFormsApp.ModuloEquipamentos;
using GestaoEquipamentos.WinFormsApp.ModuloFabricantes;
using GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento;

namespace GestaoEquipamentos.WinFormsApp
{
    public partial class TelaPrincipalForm : Form
    {
        private EquipamentosController _equipamentosController { get; set; }
        private TipoDeEquipamentoController _tipoDeEquipamentoController { get; set; }
        private FabricanteController _fabricanteController { get; set; }
        private CsvController _csvController { get; set; }
        private ClientesController _clientesController { get; set; }


        public TelaPrincipalForm()
        {
            InitializeComponent();
            _equipamentosController = new EquipamentosController();
            _tipoDeEquipamentoController = new TipoDeEquipamentoController();

            var _repositorioFabricanteSemContrato = new RepositorioFabricanteEmArquivo();

            //SOL "I" D 
            //IOC

            _fabricanteController = new FabricanteController(
                _repositorioFabricanteSemContrato,
                _repositorioFabricanteSemContrato);

            _csvController = new CsvController(
                _equipamentosController,
                _equipamentosController.ObterEquipamentos());

            _clientesController = new ClientesController();
        }

        private void buttonEquipamentos_Click(object sender, EventArgs e)
        {
            Equipamentos();
        }

        private void Equipamentos()
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(_equipamentosController.View);
            _equipamentosController.View.Atualizar();
        }

        private void equipamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Equipamentos();
        }

        private void btnTipo_Click(object sender, EventArgs e)
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(_tipoDeEquipamentoController.View);
        }

        private void btnCSV_Click(object sender, EventArgs e)
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(_csvController.View);
        }

        private void btnFabricantes_Click(object sender, EventArgs e)
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(_fabricanteController.View);
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            this.panelListControl.Controls.Clear();
            this.panelListControl.Controls.Add(_clientesController.View);
        }
    }
}
