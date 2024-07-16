using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using GestaoEquipamentos.WinFormsApp.ModuloEquipamentos;
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

        IAtualizar<FabricanteModel> _atualizar { get; set; }

        private FabricanteModel _fabricanteModel;
        public FormFabricante(IAdicionar<FabricanteModel> adicionar, IAtualizar<FabricanteModel> atualizar, FabricanteModel fabricanteModel = null)
        {
            InitializeComponent();
            _adicionar = adicionar;
            _atualizar = atualizar;
            if (fabricanteModel != null) 
            {
                _fabricanteModel = new FabricanteModel();
                txtFornecedor.Text = fabricanteModel.Fornecedor;
                txtNome.Text = fabricanteModel.Nome;
                dateTimePickerCadastro.Value = fabricanteModel.Data;

                _fabricanteModel.Indice = fabricanteModel.Indice;
                btnSalvar.Text = "Atualizar";
            }else
            {
                _fabricanteModel = new FabricanteModel();
                btnSalvar.Text = "Atualizar";
            }

        }

        private void FormFabricante_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            _fabricanteModel.Nome = this.txtNome.Text;
            _fabricanteModel.Fornecedor = this.txtFornecedor.Text;
            _fabricanteModel.Data = this.dateTimePickerCadastro.Value;

            try
            {
                if (_fabricanteModel.Indice == -1)
                {
                    _adicionar.Adicionar(_fabricanteModel);
                }
                else
                {
                    _atualizar.Atualizar(_fabricanteModel);

                }
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
