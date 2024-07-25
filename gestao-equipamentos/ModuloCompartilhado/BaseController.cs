namespace GestaoEquipamentos.WinFormsApp.ModuloCompartilhado
{
    public abstract class BaseController
    {
        public virtual ViewUserControl View { get; set; }
    }

    public class ViewUserControl : UserControl
    {
        public virtual void Atualizar()
        {

        }
    }
}
