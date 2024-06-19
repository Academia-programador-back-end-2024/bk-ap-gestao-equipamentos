namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamentos
{
    public partial class FormEquipamento : Form
    {
        public EquipamentoModel EquipamentoModel { get; set; }

        public FormEquipamento()
        {
            InitializeComponent();
            EquipamentoModel = new EquipamentoModel();
            toolStripStatusLabelErros.Text = "";
        }

        private void toolStripStatusLabel1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            EquipamentoModel.Fabricante = txtFabricante.Text;
            EquipamentoModel.Nome = txtNome.Text;
            EquipamentoModel.Preco = decimal.Parse(txtPreco.Text);
            EquipamentoModel.DataUltimaManutencao = dateTimePickermanutencao.Value;
            EquipamentoModel.DataDeFabricacao = dateTimePickerFabricacao.Value;
            EquipamentoModel.Numero = int.Parse(txtNumero.Text);
            EquipamentoModel.NumeroDeSerie = txtNumeroSerie.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        internal void ExibirMensagemErro(string resultado)
        {
            toolStripStatusLabelErros.Text = resultado;
            this.DialogResult = DialogResult.Abort;
        }
    }
}
