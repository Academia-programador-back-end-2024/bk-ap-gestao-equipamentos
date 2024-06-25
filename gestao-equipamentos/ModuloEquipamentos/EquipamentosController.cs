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

    public abstract class BaseController
    {
        public RepositorioEquipamentos _repositorioEquipamentos { get; set; }
        public UserControl UserControl { get; set; }
    }

    public class EquipamentosController :
        BaseController,
        IAdicionarEquipamento,
        IAtualizarEquipamento
    {
        public EquipamentosController()
        {
            _repositorioEquipamentos = new RepositorioEquipamentos();
            UserControl = new UserControlEquipamentos(this);
        }

        //Read
        public List<EquipamentoModel> ObterEquipamentos()
        {
            //Página
            //Entende o contexto do usuario

            return _repositorioEquipamentos.ObterEquipamentos();
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
                _repositorioEquipamentos.AdicionarEquipamento(equipamento);
                return;
            }
            throw new AdicionarEquipamentoException(resultado);
        }

        public void AtualizarEquipamento(EquipamentoModel equipamento)
        {
            var resultado = equipamento.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                _repositorioEquipamentos.AtualizarEquipamento(equipamento);
                return;
            }
            throw new AdicionarEquipamentoException(resultado);
        }
    }

    public class AdicionarEquipamentoException : Exception
    {
        public AdicionarEquipamentoException(string message) : base(message)
        {
        }
    }
}
