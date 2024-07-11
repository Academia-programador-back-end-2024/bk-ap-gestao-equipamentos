using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.WinFormsApp.ModuloFabricantes
{

    public class FabricanteController : BaseController
    {
        private RepositorioFabricante RepositorioFabricante { get; set; }
        public FabricanteController()
        {
            RepositorioFabricante = new RepositorioFabricante(); 
            base.View = new UserControlFabricantes(this);
        }

        public List<FabricanteModel> ObterFabricantes()
        {
            return RepositorioFabricante.ObterTodos();
        }
    }
}
