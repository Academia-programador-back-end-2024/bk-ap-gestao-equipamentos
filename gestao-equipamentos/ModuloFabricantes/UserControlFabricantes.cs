using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GestaoEquipamentos.WinFormsApp.ModuloFabricantes
{
    public partial class UserControlFabricantes : ViewUserControl
    {
        FabricanteController fabricanteController;
        public UserControlFabricantes(FabricanteController fabricanteController)
        {
            InitializeComponent();
            this.fabricanteController = fabricanteController;
            Atualizar();
        }

        public override void Atualizar()
        {
            this.listBoxTipos.DataSource = null;
            this.listBoxTipos.DataSource = fabricanteController.ObterFabricantes();

        }

    }
}
