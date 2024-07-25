using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloClientes
{
    public partial class UcClientesView : ViewUserControl
    {
        private ClientesController _clientesController { get; set; }

        public UcClientesView(ClientesController clientesController)
        {
            InitializeComponent();
            _clientesController = clientesController;
            Atualizar();
        }

        public override void Atualizar()
        {
            this.listBoxTipos.DataSource = null;
            this.listBoxTipos.DataSource = _clientesController.ObterTodos();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _clientesController.MostrarFormModel();
            Atualizar();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxTipos.SelectedItems[0] is ClienteModel clienteModel)
            {
                _clientesController.MostrarFormModel(clienteModel);
                Atualizar();
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxTipos.SelectedItems[0] is ClienteModel clienteModel)
            {
                _clientesController.MostrarViewFormDeleteModel(clienteModel);
                Atualizar();
            }
        }
    }
}
