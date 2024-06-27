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

        public List<TipoDeEquipamentoModel> ObterTodos()
        {
            return ItensRepositorio;
        }


        public void Atualizar(TipoDeEquipamentoModel tipodeDeEquipamento)
        {
            ItensRepositorio[tipodeDeEquipamento.Indice] = tipodeDeEquipamento;
        }

        public override void Excluir(TipoDeEquipamentoModel tipoDeEquipamento)
        {
            Excluir(tipoDeEquipamento);
            for (int i = 0; i < ItensRepositorio.Count; i++)
            {
                ItensRepositorio[i].Indice = i;
            }
        }

    }
}
