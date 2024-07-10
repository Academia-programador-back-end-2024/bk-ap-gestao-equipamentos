using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;
using GestaoEquipamentos.WinFormsApp.ModuloEquipamentos;

namespace GestaoEquipamentos.WinFormsApp.ModuloCSV
{

    public interface IExportar
    {
        bool Exportar(ref string caminhoDoCsv);
    }

    public interface IImportar
    {
        bool Importar(string caminhoDoCsv);
    }

    public class CsvController : BaseController, IExportar, IImportar
    {
        const int PosicaoNumero = 0;
        const int PosNome = 1;
        const int PosPreco = 2;
        const int PosNumeroDeSerie = 3;
        const int PosDataDeFabricaco = 4;
        const int PosFabricante = 5;
        const int PosDataUltimaManutencao = 6;
        const string CabecalhoCsv = "Número;Nome do Equipamento;Preço;Número de Série;Data de Fabricação;Fabricante;Data da Última Manutenção";
        IAdicionar<EquipamentoModel> Adicionar { get; set; }
        List<EquipamentoModel> Equipamentos { get; set; }
        public CsvController(IAdicionar<EquipamentoModel> adicionar, List<EquipamentoModel> equipamentoModels)
        {
            base.View = new UserControlCsv(this, this);
            Adicionar = adicionar;
            Equipamentos = equipamentoModels;
        }

        public bool Importar(string caminhoDoCsv)
        {
            var conteudoArquivo = string.Empty;

            conteudoArquivo = File.ReadAllText(caminhoDoCsv);
            /*
             * 
Número;Nome do Equipamento;Preço;Número de Série;Data de Fabricação;Fabricante;Data da Última Manutenção
001;Computador Dell XPS;3500.00;SN123456;2022-01-15;Dell;2023-06-12
002;Impressora HP LaserJet;1200.00;SN234567;2021-11-20;HP;2023-06-01
003;Projetor Epson;2500.00;SN345678;2023-03-05;Epson;2023-06-05
004;Roteador TP-Link;300.00;SN456789;2020-07-18;TP-Link;2023-05-15
005;Telefone IP Cisco;600.00;SN567890;2019-09-25;Cisco;2023-04-20
006;Notebook Lenovo ThinkPad;4500.00;SN678901;2021-06-10;Lenovo;2023-05-30
007;Monitor LG UltraWide;1200.00;SN789012;2022-04-12;LG;2023-03-12
008;Scanner Canon;800.00;SN890123;2021-08-30;Canon;2023-02-15
009;Servidor Dell PowerEdge;15000.00;SN901234;2020-02-25;Dell;2023-01-25
010;Switch Cisco;2000.00;SN012345;2019-12-15;Cisco;2023-04-05
             */

            string[] linhasCsv = conteudoArquivo.Split("\r\n");
            for (int i = 1; i < linhasCsv.Length; i++)
            {
                string[] propriedadesEquipamento = linhasCsv[i].Split(";");

                EquipamentoModel model = new EquipamentoModel();
                model.Numero = int.Parse(propriedadesEquipamento[PosicaoNumero]);
                model.Nome = propriedadesEquipamento[PosNome];
                model.Preco = decimal.Parse(propriedadesEquipamento[PosPreco]);
                model.NumeroDeSerie = propriedadesEquipamento[PosNumeroDeSerie];
                model.DataDeFabricacao = DateTime.Parse(propriedadesEquipamento[PosDataDeFabricaco]);
                model.Fabricante = propriedadesEquipamento[PosFabricante];
                model.DataUltimaManutencao = DateTime.Parse(propriedadesEquipamento[PosDataUltimaManutencao]);

                Adicionar.Adicionar(model);
            }

            return true;
        }

        public bool Exportar(ref string caminhoDoCsv)
        {
            var conteudoArquivo = string.Empty;
            caminhoDoCsv = "caminhoExportar.csv";
            conteudoArquivo = CabecalhoCsv;

            foreach (var equipamento in Equipamentos)
            {
                conteudoArquivo += "\r\n";
                //TODO: 
                var linhasCsv = string.Empty;

                conteudoArquivo += linhasCsv;
            }

            File.WriteAllText(caminhoDoCsv, conteudoArquivo);
            return true;
        }
    }
}
