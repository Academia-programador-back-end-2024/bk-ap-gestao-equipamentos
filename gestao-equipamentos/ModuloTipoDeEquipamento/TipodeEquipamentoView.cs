using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento
{
    public partial class TipodeEquipamentoView : ViewUserControl
    {
        private readonly TipoDeEquipamentoController _tiposDeEquipamentoController;
        public TipodeEquipamentoView(TipoDeEquipamentoController tipoDeEquipamentoController)
        {
            InitializeComponent();
            _tiposDeEquipamentoController = tipoDeEquipamentoController;
            Atualizar();
        }


        public override void Atualizar()
        {
            this.listBoxTipos.DataSource = null;
            this.listBoxTipos.DataSource = _tiposDeEquipamentoController.ObterTiposDeEquipamentos();
        }

        private void adicionarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _tiposDeEquipamentoController.MostrarViewFormTiposDeEquipamento();
            Atualizar();
        }

        private void editarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxTipos.SelectedItems[0] is TipoDeEquipamentoModel tipoDeequipamentoModel)
            {
                _tiposDeEquipamentoController.MostrarViewFormTiposDeEquipamento(tipoDeequipamentoModel);
                Atualizar();
            }
        }

        private void removerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (listBoxTipos.SelectedItems[0] is TipoDeEquipamentoModel tipoDeequipamentoModel)
            {
                _tiposDeEquipamentoController.MostrarViewFormDeleteTipoDeEquipamento(tipoDeequipamentoModel);
                Atualizar();
            }
        }
    }
}
