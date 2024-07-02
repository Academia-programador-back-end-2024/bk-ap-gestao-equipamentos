namespace GestaoEquipamentos.WinFormsApp.ModuloCompartilhado
{
    public abstract class BaseRepositorio<T> where T : BaseModel
    {
        protected List<T> ItensRepositorio { get; set; }

        private T BaseModel { get; set; }

        protected BaseRepositorio()
        {
            ItensRepositorio = new List<T>();
            this.Semear();
        }

        //Create
        public virtual void Adicionar(T objeto)
        {
            objeto.Indice = Indice();
            ItensRepositorio.Add(objeto);
        }
        protected int Indice()
        {
            return ItensRepositorio.Count;
        }

        //Read
        public List<T> ObterTodos()
        {
            return ItensRepositorio;
        }

        //Update
        public virtual void Atualizar(T objeto)
        {
            ItensRepositorio[objeto.Indice] = objeto;
        }

        //Delete
        public virtual void Excluir(T objeto)
        {
            ItensRepositorio.Remove(objeto);
            for (int i = 0; i < ItensRepositorio.Count; i++)
            {
                ItensRepositorio[i].Indice = i;
            }
        }

        public abstract void Semear();

    }
}
