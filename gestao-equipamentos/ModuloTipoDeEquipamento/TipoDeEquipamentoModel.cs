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
            return string.Empty;
        }

        public override string ToString()
        {
            return $"{Nome}¬{Descricao}¬{Componentes}";
        }
    }
}
