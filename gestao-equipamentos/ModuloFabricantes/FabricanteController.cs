using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento;

namespace GestaoEquipamentos.WinFormsApp.ModuloFabricantes
{

    public class FabricanteController : BaseController, IAdicionar<FabricanteModel>, IAtualizar<FabricanteModel>
    {

        private IRepositorio<FabricanteModel> _repositorio { get; set; }
        private IRepositorioFabricante _repositorioFabricante { get; set; }

        public FabricanteController(
            IRepositorio<FabricanteModel> repositorio,
            IRepositorioFabricante repositorioFabricante
            )
        {
            _repositorio = repositorio;
            _repositorioFabricante = repositorioFabricante;

            base.View = new UserControlFabricantes(this);
        }

        public List<FabricanteModel> ObterFabricantes()
        {
            return _repositorio.ObterTodos();
        }
        public void MostrarViewFormFabricante(FabricanteModel fabricanteModel = null)
        {
            FormFabricante formFabricante =
                new FormFabricante(this, this, fabricanteModel);
            formFabricante.ShowDialog();
        }

        public void Adicionar(FabricanteModel fabricante)
        {
            var resultado = fabricante.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                if (_repositorioFabricante.VerificarPorNome(fabricante.Nome))
                {
                    resultado = "Já existe fabricante com este nome cadastrado! ";
                    throw new FabricanteException(resultado);
                }
                _repositorio.Adicionar(fabricante);
                return;
            }
            throw new FabricanteException(resultado);
        }

        public void Atualizar(FabricanteModel fabricanteModel)
        {
            var resultado = fabricanteModel.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                if (_repositorioFabricante.VerificarPorNome(fabricanteModel.Nome))
                {
                    resultado = "Já existe fabricante com este nome cadastrado! ";
                    throw new FabricanteException(resultado);
                }
                _repositorio.Atualizar(fabricanteModel);
                return;
            }
            throw new AdicionarTipoDeEquipamentoException(resultado);
        }

        public void MostrarViewFormDeleteFabricante(FabricanteModel fabricanteModel)
        {
            var resultado =
            MessageBox.
            Show(
                 $"Você confirma a remoção do fabricante {fabricanteModel.Nome}",
                 "Remover fabricante",
                 MessageBoxButtons.YesNoCancel);

            if (DialogResult.Yes == resultado)
            {
                _repositorio.Excluir(fabricanteModel);
            }
        }
    }

    public class FabricanteException : Exception
    {
        public FabricanteException(string erro) : base(erro)
        {
        }
    }
}
