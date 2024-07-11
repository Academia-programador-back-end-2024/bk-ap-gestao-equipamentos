namespace GestaoEquipamentos.WinFormsApp.ModuloCompartilhado
{
    public abstract class BaseController
    {
        public virtual ViewUserControl View { get; set; }
    }

    public class ViewUserControl : UserControl, Iview
    {
        public virtual void Atualizar()
        {
            throw new NotImplementedException();
        }
    }
    public interface Iview
    {
        void Atualizar();
    }
}
