using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
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
    public partial class FormFabricante : Form
    {
        IAdicionar<FabricanteModel> _adicionar { get; set; }
        private FabricanteModel fabricanteModel;
        public FormFabricante(IAdicionar<FabricanteModel> adicionar)
        {
            InitializeComponent();
            fabricanteModel = new FabricanteModel();
            _adicionar = adicionar;
        }

        private void FormFabricante_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            fabricanteModel.Nome = this.txtNome.Text;
            fabricanteModel.Fornecedor = this.txtFornecedor.Text;
            fabricanteModel.Data = this.dateTimePickerCadastro.Value;

            try
            {
                _adicionar.Adicionar(fabricanteModel);
                //Se deu certo
                this.DialogResult = DialogResult.OK;
                this.Close();
            } 
            catch (Exception ex)
            {
                toolStripStatusLabelErros.Text = $"Erro: {ex.Message}";
            }
        }
    }
}
