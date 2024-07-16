namespace GestaoEquipamentos.WinFormsApp.ModuloCompartilhado
{
    //SOLID
    //S - Simple responsability
    public interface IAdicionar<T>
    {
        void Adicionar(T objeto);
    }

    public interface IAtualizar<T>
    {
        void Atualizar(T objeto);
    }
}
