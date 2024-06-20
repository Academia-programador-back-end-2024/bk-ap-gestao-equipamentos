namespace GestaoEquipamentos.WinFormsApp.ModuloCompartilhado
{
    public abstract class BaseModel
    {
        public int Indice { get; set; }
        //é obrigatorio que a classe vai herda ele, implemente obrigatoriamente.
        public abstract string Validar();

        protected BaseModel()
        {
            Indice = -1;
        }
    }
}
