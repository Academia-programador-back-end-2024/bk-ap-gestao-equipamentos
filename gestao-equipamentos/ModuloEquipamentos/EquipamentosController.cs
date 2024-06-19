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
            string resultado = string.Empty;
            FormEquipamento formEquipamento = new FormEquipamento();
            // Laço para garantir que o formulário será reaberto em caso de erros de validação
            do
            {
                formEquipamento.ExibirMensagemErro(resultado);
                if (formEquipamento.ShowDialog() == DialogResult.OK)
                {
                    EquipamentoModel equipamento = formEquipamento.EquipamentoModel;
                    resultado = equipamento.Validar();

                    // Se não houver erros de validação, adicionar o equipamento
                    if (string.IsNullOrEmpty(resultado))
                    {
                        _repositorioEquipamentos.AdicionarEquipamento(equipamento);
                        break;
                    }
                }
                else
                {
                    break;
                }

            } while (!string.IsNullOrEmpty(resultado));

        }
    }
}
