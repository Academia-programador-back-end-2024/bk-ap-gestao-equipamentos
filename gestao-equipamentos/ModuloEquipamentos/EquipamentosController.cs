namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamentos
{
    public class EquipamentosController
    {
        public RepositorioEquipamentos _repositorioEquipamentos { get; set; }
        public EquipamentosController()
        {
            _repositorioEquipamentos = new RepositorioEquipamentos();
        }

        public List<EquipamentoModel> ObterEquipamentos()
        {
            //Página
            //Entende o contexto do usuario

            return _repositorioEquipamentos.ObterEquipamentos();
        }

        public void AdicionarEquipamento()
        {
            FormEquipamento formEquipamento = new FormEquipamento();
            formEquipamento.ShowDialog();

            //Validar as regras de adição
            EquipamentoModel equipamento = formEquipamento.EquipamentoModel;



            _repositorioEquipamentos.AdicionarEquipamento(equipamento);

        }
    }
}
