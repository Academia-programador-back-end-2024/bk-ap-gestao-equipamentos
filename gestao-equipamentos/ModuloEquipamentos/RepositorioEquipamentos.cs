namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamentos
{
    public class RepositorioEquipamentos
    {
        private List<EquipamentoModel> _equipamentos { get; set; }

        public RepositorioEquipamentos()
        {
            _equipamentos = new List<EquipamentoModel>();
            Semear();
        }

        private void Semear()
        {
            _equipamentos.Add(new EquipamentoModel()
            {
                DataDeFabricacao = new DateTime(2020, 12, 09),
                DataUltimaManutencao = new DateTime(2020, 12, 09),
                Fabricante = "HP",
                Nome = "Laserjet J6545",
                Numero = 1,
                NumeroDeSerie = "123456789",
                Preco = 1000
            });

            _equipamentos.Add(new EquipamentoModel()
            {
                DataDeFabricacao = new DateTime(2021, 12, 09),
                DataUltimaManutencao = new DateTime(2021, 12, 09),
                Fabricante = "SAMSUNG",
                Nome = "S21",
                Numero = 2,
                NumeroDeSerie = "987654321",//MEI
                Preco = 5000
            });
        }

        public List<EquipamentoModel> ObterEquipamentos()
        {
            return _equipamentos;
        }
    }
}
