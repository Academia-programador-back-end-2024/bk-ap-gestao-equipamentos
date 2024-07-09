using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento;

namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamentos
{
    public interface IAtualizarEquipamento
    {
        void AtualizarEquipamento(EquipamentoModel equipamento);
    }

    public class EquipamentosController : BaseController,
        IAdicionar<EquipamentoModel>,
        IAtualizarEquipamento
    {
        private RepositorioEquipamentos _repositorioEquipamentos { get; set; }
        private TipoDeEquipamentoRepositorio _tipoDeEquipamentoRepositorio { get; set; }
        public EquipamentosController(TipoDeEquipamentoRepositorio tipoDeEquipamentoRepositorio)
        {
            _repositorioEquipamentos = new RepositorioEquipamentos();
            _tipoDeEquipamentoRepositorio = tipoDeEquipamentoRepositorio;
            View = new UserControlEquipamentos(this);
        }

        public EquipamentosController()
        {
            _repositorioEquipamentos = new RepositorioEquipamentos();
            _tipoDeEquipamentoRepositorio = TipoDeEquipamentoRepositorio.Instancia;
            View = new UserControlEquipamentos(this);
        }

        //Read
        public List<EquipamentoModel> ObterEquipamentos()
        {
            //Página
            //Entende o contexto do usuario

            return _repositorioEquipamentos.ObterTodos();
        }

        //Pedir iteração do usuario

        //Retorono do model feito na iteração do usuario

        //S - SRP, simple resposability principle
        //OLID
        //I IOC

        public void MostrarViewFormEquipamento(EquipamentoModel model = null)
        {
            FormEquipamento formEquipamento =
                new FormEquipamento(
                    this,
                    this,
                    _tipoDeEquipamentoRepositorio.ObterTodos(),
                    model);
            formEquipamento.ShowDialog();
        }

        //Create - Update
        public void Adicionar(EquipamentoModel equipamento)
        {
            var resultado = equipamento.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                _repositorioEquipamentos.Adicionar(equipamento);
                return;
            }
            throw new AdicionarEquipamentoException(resultado);
        }

        public void AtualizarEquipamento(EquipamentoModel equipamento)
        {
            var resultado = equipamento.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                _repositorioEquipamentos.Atualizar(equipamento);
                return;
            }
            throw new AdicionarEquipamentoException(resultado);
        }

        public void MostrarViewFormDeleteEquipamento(EquipamentoModel equipamentoModel)
        {
            var resultado =
                MessageBox.
                Show(
                $"Você confirma a remoção do equipamento {equipamentoModel.Nome}",
                "Remover equipamento",
                MessageBoxButtons.YesNoCancel);

            if (DialogResult.Yes == resultado)
            {
                _repositorioEquipamentos.Excluir(equipamentoModel);
            }
        }
    }
}
