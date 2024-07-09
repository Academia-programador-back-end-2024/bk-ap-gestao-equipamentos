using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento
{
    public partial class FormTipoDeEquipamento : Form
    {
        TipoDeEquipamentoModel TipoDeEquipamentoModel { get; set; }
        TipoDeEquipamentoController TipoDeEquipamentoController { get; set; }

        //ILogger<FormTipoDeEquipamento> Logger { get; set; }

        IAdicionar<TipoDeEquipamentoModel> _adicionar { get; set; }
        public FormTipoDeEquipamento(
            TipoDeEquipamentoModel tipoDeEquipamentoModel,
            TipoDeEquipamentoController tipoDeEquipamentoController,
            IAdicionar<TipoDeEquipamentoModel> adicionar)
        {
            InitializeComponent();
            if (tipoDeEquipamentoModel != null)
            {
                TipoDeEquipamentoModel = tipoDeEquipamentoModel;
                txtNome.Text = tipoDeEquipamentoModel.Nome;
                richTxtComponentes.Text = tipoDeEquipamentoModel.Componentes;
                richTxtDescricao.Text = tipoDeEquipamentoModel.Descricao;

                btnSalvar.Text = "Atualizar";
            }
            else
            {
                TipoDeEquipamentoModel = new TipoDeEquipamentoModel();
                btnSalvar.Text = "Adicionar";
            }
            toolStripStatusLabelErros.Text = "";

            TipoDeEquipamentoController = tipoDeEquipamentoController;
            _adicionar = adicionar;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            TipoDeEquipamentoModel.Nome = txtNome.Text;
            TipoDeEquipamentoModel.Descricao = richTxtDescricao.Text;
            TipoDeEquipamentoModel.Componentes = richTxtComponentes.Text;

            try
            {
                if (TipoDeEquipamentoModel.Indice == -1)
                {
                    _adicionar.Adicionar(TipoDeEquipamentoModel);
                }
                else
                {
                    TipoDeEquipamentoController.AtualizarTipoDeEquipamento(TipoDeEquipamentoModel);
                }
                //Se deu certo
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (AdicionarTipoDeEquipamentoException ex)
            {
                toolStripStatusLabelErros.Text = $"Erro: {ex.Message}";
            }
            catch (Exception e2)
            {
                toolStripStatusLabelErros.Text = $"Erro: {e2.Message}";
            }
        }
    }
}
