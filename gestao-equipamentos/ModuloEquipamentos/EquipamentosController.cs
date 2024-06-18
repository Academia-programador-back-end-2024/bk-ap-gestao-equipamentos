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
    }
}
