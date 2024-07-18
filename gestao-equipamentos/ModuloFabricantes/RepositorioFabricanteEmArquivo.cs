using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloFabricantes
{
    public class RepositorioFabricanteEmArquivo :
        RepositorioEmArquivo<FabricanteModel>,
        IRepositorioFabricante
    {
        public RepositorioFabricanteEmArquivo()
        {
            Semear();
        }

        public bool VerificarPorNome(string nome)
        {
            //LINQ
            //DELEGATE 
            //LAMBDA , expressão anonimo, metodo anonimo
            return _models.Exists(fabricante => fabricante.Nome == nome);
        }
    }
}
