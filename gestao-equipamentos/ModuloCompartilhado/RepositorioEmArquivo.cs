using System.Text.Json;

namespace GestaoEquipamentos.WinFormsApp.ModuloCompartilhado
{
    public abstract class RepositorioEmArquivo<T> :
        IRepositorio<T> where T : BaseModel
    {

        private string NomeArquivoRepositorio { get; set; }
        protected List<T> _models { get; set; }

        protected RepositorioEmArquivo()
        {
            var modelName = typeof(T).Name;
            NomeArquivoRepositorio = $"repositorio-{modelName}.json";
        }

        public void Adicionar(T objeto)
        {
            _models.Add(objeto);
            EscreverModelsEmArquivo();
        }

        public void Atualizar(T fabricante)
        {
            var fabricanteParaAtualizar =
                _models.Find(fabricante => fabricante.Indice == fabricante.Indice);

            if (fabricanteParaAtualizar != null)
            {
                fabricanteParaAtualizar = fabricante;
                EscreverModelsEmArquivo();
            }
        }

        public void Excluir(T objeto)
        {
            _models.Remove(objeto);
            EscreverModelsEmArquivo();
        }

        public List<T> ObterTodos()
        {
            LerDados();
            return _models;
        }

        public void Semear()
        {
            LerDados();
            if (_models == null)
            {
                _models = new List<T>();
            }
        }
        private void EscreverModelsEmArquivo()
        {
            string conteudoArquivoTipos =
                JsonSerializer.Serialize
                (_models);

            File.WriteAllText(NomeArquivoRepositorio, conteudoArquivoTipos);
        }

        private void LerDados()
        {
            if (File.Exists(NomeArquivoRepositorio))
            {
                string conteudoArquivoTipos = File.ReadAllText(NomeArquivoRepositorio);
                _models =
                    JsonSerializer.Deserialize<List<T>>
                    (conteudoArquivoTipos);
            }
        }
    }
}
