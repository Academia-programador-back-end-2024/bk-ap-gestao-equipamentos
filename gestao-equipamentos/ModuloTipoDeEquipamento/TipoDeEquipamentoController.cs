using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento
{
    public class TipoDeEquipamentoController : BaseController
    {
        private TipoDeEquipamentoRepositorio _tipoDeEquipamentoRepositorio { get; set; }
        public TipoDeEquipamentoController()
        {
            _tipoDeEquipamentoRepositorio = new TipoDeEquipamentoRepositorio();
            this.View = new TipodeEquipamentoView(this);
        }

        public void MostrarViewFormDeleteTipoDeEquipamento(TipoDeEquipamentoModel tipoDeequipamentoModel)
        {
            var resultado =
            MessageBox.
            Show(
                 $"Você confirma a remoção do tipo de equipamento {tipoDeequipamentoModel.Nome}",
                 "Remover tipo de equipamento",
                 MessageBoxButtons.YesNoCancel);

            if (DialogResult.Yes == resultado)
            {
                _tipoDeEquipamentoRepositorio.Excluir(tipoDeequipamentoModel);
            }
        }

        public void MostrarViewFormTiposDeEquipamento(TipoDeEquipamentoModel? tipoDeequipamentoModel = null)
        {
            FormTipoDeEquipamento formTipoDeEquipamento = new FormTipoDeEquipamento(tipoDeequipamentoModel, this);
            formTipoDeEquipamento.ShowDialog();
        }

        public void AdicionarTipoDeEquipamento(TipoDeEquipamentoModel tipoDeEquipamento)
        {
            var resultado = tipoDeEquipamento.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                var tipoExistente = _tipoDeEquipamentoRepositorio.BusquePorNome(tipoDeEquipamento.Nome);

                if (tipoExistente != null)
                {
                    resultado += "Já existe um tipo com este nome.";
                    throw new AdicionarTipoDeEquipamentoException(resultado);
                }
                _tipoDeEquipamentoRepositorio.Adicionar(tipoDeEquipamento);
                return;
            }
            throw new AdicionarTipoDeEquipamentoException(resultado);
        }


        public List<TipoDeEquipamentoModel> ObterTiposDeEquipamentos()
        {
            return _tipoDeEquipamentoRepositorio.ObterTodos();
        }

        internal void AtualizarTipoDeEquipamento(TipoDeEquipamentoModel tipoDeEquipamentoModel)
        {
            var resultado = tipoDeEquipamentoModel.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                _tipoDeEquipamentoRepositorio.Adicionar(tipoDeEquipamentoModel);

            }
            throw new AdicionarTipoDeEquipamentoException(resultado);
        }
    }

    public class AdicionarTipoDeEquipamentoException : Exception
    {
        public AdicionarTipoDeEquipamentoException(string message) : base(message)
        {
        }
    }
}
