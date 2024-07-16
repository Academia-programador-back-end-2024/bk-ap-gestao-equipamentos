using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.WinFormsApp.ModuloFabricantes
{
    public class RepositorioFabricante : BaseRepositorio<FabricanteModel>
    {
        public RepositorioFabricante()
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
