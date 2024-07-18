using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloFabricantes
{
    public class RepositorioFabricanteEmMemoria :
        BaseRepositorioEmMemoria<FabricanteModel>,
        IRepositorio<FabricanteModel>,
        IRepositorioFabricante
    {
        public RepositorioFabricanteEmMemoria()
        {

        }
        public override void Semear()
        {
            base.ItensRepositorio.Add(new FabricanteModel()
            {
                Indice = Indice(),
                Nome = "Samsung",
                Data = DateTime.Now,
                Fornecedor = "Academia do programador"
            });

        }

        public bool VerificarPorNome(string nome)
        {
            foreach (var fabricante in ItensRepositorio)
            {
                if (fabricante.Nome == nome)
                {
                    return true;
                }
            }
            return false;
        }
    }
}
