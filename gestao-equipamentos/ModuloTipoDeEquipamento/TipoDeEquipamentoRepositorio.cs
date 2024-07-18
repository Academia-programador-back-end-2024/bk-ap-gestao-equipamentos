using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using System.Text.Json;

namespace GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento
{
    public class TipoDeEquipamentoRepositorio : BaseRepositorioEmMemoria<TipoDeEquipamentoModel>
    {
        const string nomeArquivoTipos = "tipos-de-equipamento.json";
        const string diretorioTipo = "tipo";

        //Singleton.
        //Padrão de projeto de criação
        //Uma classe que é singleton, ela só pode ter uma instancia dela mesmo
        //Contrutor privado
        //Um objeto statico privado
        //Uma propriedade static somente com get, poderia ser também um metodo

        private static TipoDeEquipamentoRepositorio TipoDeEquipamentoRepositorioSingleton { get; set; }
        public static TipoDeEquipamentoRepositorio Instancia
        {
            get
            {
                if (TipoDeEquipamentoRepositorioSingleton == null)
                {
                    TipoDeEquipamentoRepositorioSingleton = new TipoDeEquipamentoRepositorio();
                }
                return TipoDeEquipamentoRepositorioSingleton;
            }
        }

        private TipoDeEquipamentoRepositorio() : base()
        {
            if (File.Exists(nomeArquivoTipos))
            {
                string conteudoArquivoTipos = File.ReadAllText(nomeArquivoTipos);
                ItensRepositorio =
                    JsonSerializer.Deserialize<List<TipoDeEquipamentoModel>>
                    (conteudoArquivoTipos);
            }
        }

        ~TipoDeEquipamentoRepositorio()
        {
            EscreverModelsEmArquivo();
        }

        public override void Semear()
        {
            if (File.Exists(nomeArquivoTipos))
            {
                return;
            }

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

            EscreverModelsEmArquivo();
        }

        private void EscreverModelsEmArquivo()
        {
            string conteudoArquivoTipos =
                JsonSerializer.Serialize<List<TipoDeEquipamentoModel>>
                (ItensRepositorio);

            File.WriteAllText(nomeArquivoTipos, conteudoArquivoTipos);
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

        public override void Adicionar(TipoDeEquipamentoModel objeto)
        {
            base.Adicionar(objeto);
            EscreverModelsEmArquivo();
        }
    }
}
