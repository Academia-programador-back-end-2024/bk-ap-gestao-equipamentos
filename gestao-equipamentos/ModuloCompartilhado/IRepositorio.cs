
namespace GestaoEquipamentos.WinFormsApp.ModuloCompartilhado
{
    public interface IRepositorio<T> where T : BaseModel
    {
        void Adicionar(T objeto);
        void Atualizar(T objeto);
        void Excluir(T objeto);
        List<T> ObterTodos();
        void Semear();
    }
}