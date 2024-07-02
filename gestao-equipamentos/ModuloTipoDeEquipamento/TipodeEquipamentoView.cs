namespace GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento
{
    public partial class TipodeEquipamentoView : UserControl
    {
        private readonly TipoDeEquipamentoController _tiposDeEquipamentoController;
        public TipodeEquipamentoView(TipoDeEquipamentoController tipoDeEquipamentoController)
        {
            InitializeComponent();
            _tiposDeEquipamentoController = tipoDeEquipamentoController;
            AtualizarGrid();
        }


        private void AtualizarGrid()
        {
            this.listBoxTipos.DataSource = null;
            this.listBoxTipos.DataSource = _tiposDeEquipamentoController.ObterTiposDeEquipamentos();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tiposDeEquipamentoController.MostrarViewFormTiposDeEquipamento();
            AtualizarGrid();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxTipos.SelectedItems[0] is TipoDeEquipamentoModel tipoDeequipamentoModel)
            {
                _tiposDeEquipamentoController.MostrarViewFormTiposDeEquipamento(tipoDeequipamentoModel);
                AtualizarGrid();
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxTipos.SelectedItems[0] is TipoDeEquipamentoModel tipoDeequipamentoModel)
            {
                _tiposDeEquipamentoController.MostrarViewFormDeleteTipoDeEquipamento(tipoDeequipamentoModel);
                AtualizarGrid();
            }
        }
    }
}
