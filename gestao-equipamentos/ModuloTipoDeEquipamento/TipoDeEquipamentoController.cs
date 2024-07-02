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
            throw new NotImplementedException();
        }

        public void MostrarViewFormTiposDeEquipamento(TipoDeEquipamentoModel? tipoDeequipamentoModel = null)
        {
            throw new NotImplementedException();
        }

        public List<TipoDeEquipamentoModel> ObterTiposDeEquipamentos()
        {
            return _tipoDeEquipamentoRepositorio.ObterTodos();
        }
    }
}
