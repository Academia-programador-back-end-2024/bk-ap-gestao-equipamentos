namespace GestaoEquipamentos.WinFormsApp.ModuloCompartilhado
{
    public abstract class BaseController
    {
        public virtual ViewUserControl View { get; set; }
    }

    public abstract class ViewUserControl : UserControl
    {
        public abstract void Atualizar();
    }
}
