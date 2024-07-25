using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloClientes
{

    public class ClientesController : BaseController
    {
        private readonly IRepositorio<ClienteModel> _repositorio;

        public ClientesController()
        {
            _repositorio = new RepositorioClientesEmMemoria();
            View = new UcClientesView(this);
        }

        internal void MostrarFormModel(ClienteModel clienteModel = null)
        {
            throw new NotImplementedException();
        }

        internal void MostrarViewFormDeleteModel(ClienteModel clienteModel)
        {
            var resultado =
            MessageBox.
            Show(
                 $"Você confirma a remoção do cliente {clienteModel.Nome}",
                 "Remover cliente",
                 MessageBoxButtons.YesNoCancel);

            if (DialogResult.Yes == resultado)
            {
                _repositorio.Excluir(clienteModel);
            }
        }

        public List<ClienteModel> ObterTodos()
        {
            return _repositorio.ObterTodos();
        }
    }
}
