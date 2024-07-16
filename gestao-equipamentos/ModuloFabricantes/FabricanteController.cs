using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoEquipamentos.WinFormsApp.ModuloFabricantes
{

    public class FabricanteController : BaseController, IAdicionar<FabricanteModel>, IAtualizar<FabricanteModel>
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
        public void MostrarViewFormFabricante(FabricanteModel fabricanteModel = null)
        {
            FormFabricante formFabricante =
                new FormFabricante(this, this, fabricanteModel);
            formFabricante.ShowDialog();
        }

        public void Adicionar(FabricanteModel fabricante)
        {
            var resultado = fabricante.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                if (RepositorioFabricante.VerificarPorNome(fabricante.Nome))
                {
                    resultado = "Já existe fabricante com este nome cadastrado! ";
                    throw new FabricanteException(resultado);
                }
                RepositorioFabricante.Adicionar(fabricante);
                return;
            }
            throw new FabricanteException(resultado);
        }

        public void Atualizar (FabricanteModel fabricanteModel)
        {
            var resultado = fabricanteModel.Validar();
            if (string.IsNullOrEmpty(resultado))
            {
                if (RepositorioFabricante.VerificarPorNome(fabricanteModel.Nome))
                {
                    resultado = "Já existe fabricante com este nome cadastrado! ";
                    throw new FabricanteException(resultado);
                }
                RepositorioFabricante.Atualizar(fabricanteModel);
                return;
            }
            throw new AdicionarTipoDeEquipamentoException(resultado);
        }
    }

    public class FabricanteException : Exception
    {
        public FabricanteException(string erro) : base(erro) 
        {
        }
    }
}
