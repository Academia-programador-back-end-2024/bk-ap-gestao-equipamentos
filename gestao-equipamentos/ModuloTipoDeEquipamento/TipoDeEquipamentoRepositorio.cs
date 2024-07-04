using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento
{
    public class TipoDeEquipamentoRepositorio : BaseRepositorio<TipoDeEquipamentoModel>
    {
        public override void Semear()
        {
            ItensRepositorio.Add(new TipoDeEquipamentoModel()
            {
                Indice = Indice(),
                Nome = "Computador",
                Componentes = "Processador, Memoria, Fonte, Gabinete, Disco Rigido, Cooler",
                Descricao = "Desktop intel i5 14 32gb, com gabinete lebran james, SSD 2TB, water cooler risem mode"
            });

            ItensRepositorio.Add(new TipoDeEquipamentoModel()
            {
                Nome = "Computador GAMER",
                Componentes = "Processador, Memoria, Fonte, Gabinete, Disco Rigido, Cooler, LEDS",
                Descricao = "Desktop intel i5 14 32gb, com gabinete lebran james, SSD 2TB, water cooler risem mode, GTX 4080"
            });

            ItensRepositorio.Add(new TipoDeEquipamentoModel()
            {
                Indice = Indice(),
                Nome = "Celular",
                Componentes = "Processador, Memoria, Bateria, Disco Rigido",
                Descricao = "S23, snapdragon 751, 8gb, 4200, 512 HD"
            });
        }

        public TipoDeEquipamentoModel BusquePorNome(string nome)
        {
            foreach (TipoDeEquipamentoModel tipoDeEquipamento in ItensRepositorio)
            {
                if (tipoDeEquipamento.Equals(nome))
                {
                    return tipoDeEquipamento;
                }
            }
            return null;
        }
    }
}
