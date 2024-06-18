namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamentos
{
    public class EquipamentoModel
    {
        public int Numero { get; set; }
        public string Nome { get; set; }
        public decimal Preco { get; set; }
        public string NumeroDeSerie { get; set; }
        public DateTime DataDeFabricacao { get; set; }
        public string Fabricante { get; set; }
        public DateTime DataUltimaManutencao { get; set; }
    }
}
