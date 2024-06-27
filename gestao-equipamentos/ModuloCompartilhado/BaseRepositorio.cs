namespace GestaoEquipamentos.WinFormsApp.ModuloCompartilhado
{
    public abstract class BaseRepositorio<T>
    {
        public List<T> ItensRepositorio { get; set; }

        protected BaseRepositorio()
        {
            ItensRepositorio = new List<T>();
            this.Semear();
        }

        protected int Indice()
        {
            return ItensRepositorio.Count;
        }

        public virtual void Adicionar(T objeto)
        {
            //objeto.Indice = Indice();
            ItensRepositorio.Add(objeto);
        }
        public virtual void Excluir(T objeto)
        {
            ItensRepositorio.Remove(objeto);
        }

        public abstract void Semear();

    }
}
