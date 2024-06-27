using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamentos
{
    public interface IAdicionarEquipamento
    {
        public abstract void AdicionarEquipamento(EquipamentoModel equipamento);
    }

    public interface IAtualizarEquipamento
    {
        void AtualizarEquipamento(EquipamentoModel equipamento);
    }

    public class EquipamentosController :
        BaseController,
        IAdicionarEquipamento,
        IAtualizarEquipamento
    {
        private RepositorioEquipamentos _repositorioEquipamentos { get; set; }
        public EquipamentosController()
        {
            _repositorioEquipamentos = new RepositorioEquipamentos();
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
            FormEquipamento formEquipamento = new FormEquipamento(this, this, model);
            formEquipamento.ShowDialog();
        }

        //Create - Update
        public void AdicionarEquipamento(EquipamentoModel equipamento)
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

    public class AdicionarEquipamentoException : Exception
    {
        public AdicionarEquipamentoException(string message) : base(message)
        {
        }
    }
}
