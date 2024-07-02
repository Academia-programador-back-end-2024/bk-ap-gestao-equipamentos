using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento
{
    public class TipoDeEquipamentoRepositorio : BaseRepositorio<TipoDeEquipamentoModel>
    {
        public override void Semear()
        {
            ItensRepositorio.Add(new TipoDeEquipamentoModel()
            {
                Indice = Indice()
            });

            ItensRepositorio.Add(new TipoDeEquipamentoModel()
            {
                Indice = Indice()
            });

            ItensRepositorio.Add(new TipoDeEquipamentoModel()
            {
                Indice = Indice()
            });
        }

    }
}
