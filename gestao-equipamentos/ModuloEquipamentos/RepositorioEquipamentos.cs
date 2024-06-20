namespace GestaoEquipamentos.WinFormsApp.ModuloEquipamentos
{
    public class RepositorioEquipamentos
    {
        private static List<EquipamentoModel> _equipamentos { get; set; } = new List<EquipamentoModel>();

        public RepositorioEquipamentos()
        {
            Semear();
        }

        private void Semear()
        {
            _equipamentos.Add(
                new EquipamentoModel()
                {
                    DataDeFabricacao = new DateTime(2020, 12, 09),
                    DataUltimaManutencao = new DateTime(2020, 12, 09),
                    Fabricante = "HP",
                    Nome = "Laserjet J6545",
                    Numero = 1,
                    NumeroDeSerie = "123456789",
                    Preco = 1000,
                    Indice = Indice()
                });

            _equipamentos.Add(new EquipamentoModel()
            {
                DataDeFabricacao = new DateTime(2021, 12, 09),
                DataUltimaManutencao = new DateTime(2021, 12, 09),
                Fabricante = "SAMSUNG",
                Nome = "S21",
                Numero = 2,
                NumeroDeSerie = "987654321",//MEI
                Preco = 5000,
                Indice = Indice()
            });

            _equipamentos.Add(new EquipamentoModel()
            {
                DataDeFabricacao = new DateTime(2021, 12, 09),
                DataUltimaManutencao = new DateTime(2021, 12, 09),
                Fabricante = "LEX",
                Nome = "SSS",
                Numero = 2,
                NumeroDeSerie = "987654321",//MEI
                Preco = 5000,
                Indice = Indice()
            });
        }

        private int Indice()
        {
            return _equipamentos.Count;
        }

        public List<EquipamentoModel> ObterEquipamentos()
        {
            return _equipamentos;
        }

        public void AdicionarEquipamento(EquipamentoModel equipamento)
        {
            equipamento.Indice = Indice();
            _equipamentos.Add(equipamento);
        }

        public void AtualizarEquipamento(EquipamentoModel equipamento)
        {
            _equipamentos[equipamento.Indice] = equipamento;
        }

        public void ExcluirEquipamento(EquipamentoModel equipamento)
        {
            _equipamentos.Remove(equipamento);
        }
    }
}
