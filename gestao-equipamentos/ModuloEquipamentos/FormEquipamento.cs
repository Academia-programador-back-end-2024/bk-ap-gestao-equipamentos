namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamentos
{
    public partial class FormEquipamento : Form
    {
        private EquipamentoModel _equipamentoModel { get; set; }
        private IAdicionarEquipamento _adicionarEquipamento { get; set; }
        private IAtualizarEquipamento _atualizarEquipamento { get; set; }


        public FormEquipamento(
            IAdicionarEquipamento equipamentoControllerBase,
            IAtualizarEquipamento atualizarEquipamento,
            EquipamentoModel equipamentoModel)
        {
            InitializeComponent();
            if (equipamentoModel != null)
            {
                _equipamentoModel = equipamentoModel;

                txtFabricante.Text = _equipamentoModel.Fabricante;
                txtNome.Text = _equipamentoModel.Nome;
                txtPreco.Text = _equipamentoModel.Preco.ToString();
                dateTimePickermanutencao.Value = _equipamentoModel.DataUltimaManutencao;
                dateTimePickerFabricacao.Value = _equipamentoModel.DataDeFabricacao;
                txtNumero.Text = _equipamentoModel.Numero.ToString();
                txtNumeroSerie.Text = _equipamentoModel.NumeroDeSerie;
                btnSalvar.Text = "Atualizar";
            }
            else
            {
                _equipamentoModel = new EquipamentoModel();
                btnSalvar.Text = "Adicionar";
            }
            toolStripStatusLabelErros.Text = "";
            _adicionarEquipamento = equipamentoControllerBase;
            _atualizarEquipamento = atualizarEquipamento;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                _equipamentoModel.Fabricante = txtFabricante.Text;
                _equipamentoModel.Nome = txtNome.Text;
                _equipamentoModel.Preco = decimal.Parse(txtPreco.Text);
                _equipamentoModel.DataUltimaManutencao = dateTimePickermanutencao.Value;
                _equipamentoModel.DataDeFabricacao = dateTimePickerFabricacao.Value;
                _equipamentoModel.Numero = int.Parse(txtNumero.Text);
                _equipamentoModel.NumeroDeSerie = txtNumeroSerie.Text;
                if (_equipamentoModel.Indice == -1)
                {
                    _adicionarEquipamento.AdicionarEquipamento(_equipamentoModel);
                }
                else
                {
                    _atualizarEquipamento.AtualizarEquipamento(_equipamentoModel);
                }
                //Se deu certo
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (AdicionarEquipamentoException ax)
            {
                ExibirMensagemErro(ax.Message);
            }
            catch
            {
                ExibirMensagemErro("Preencha todos os campos corretamente");
            }
        }

        internal void ExibirMensagemErro(string resultado)
        {
            toolStripStatusLabelErros.Text = resultado;
            this.DialogResult = DialogResult.Abort;
        }
    }
}
