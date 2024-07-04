using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;


namespace GestaoEquipamentos.WinFormsApp.ModuloTipoDeEquipamento
{
    public class TipoDeEquipamentoModel : BaseModel
    {
        public string Nome { get; set; }
        public string Componentes { get; set; }
        public string Descricao { get; set; }

        public override string Validar()
        {
            string error = string.Empty;

            if (string.IsNullOrEmpty(Nome))
            {
                error += "Nome é obrigatorio.";
            }

            if (string.IsNullOrEmpty(Componentes))
            {
                error += "Componentes é obrigatorio.";
            }

            if (string.IsNullOrEmpty(Descricao))
            {
                error += "Descrição é obrigatorio.";
            }

            return error;
        }

        public override string ToString()
        {
            return $"{Nome}¬{Descricao}¬{Componentes}";
        }
    }
}
