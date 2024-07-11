using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloCSV
{
    public partial class UserControlCsv : ViewUserControl
    {
        IImportar Importar { get; set; }
        IExportar Exportar { get; set; }
        public UserControlCsv(IImportar importar, IExportar exportar)
        {
            InitializeComponent();
            Importar = importar;
            Exportar = exportar;
        }

        private void Exportar_Click(object sender, EventArgs e)
        {
            string caminhoCsv = string.Empty;
            if (Exportar.Exportar(ref caminhoCsv))
            {
                MessageBox.Show($"Exportou com sucesso, o caminho do arquivo é :{caminhoCsv}", "Exportar", MessageBoxButtons.OK);
            }
            else
            {
                //TODO
            }
        }

        private void btnImportar_Click(object sender, EventArgs e)
        {

            var caminhoArquivo = string.Empty;

            //Using IO 
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "arquivos csv (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    caminhoArquivo = openFileDialog.FileName;
                    if (Importar.Importar(caminhoArquivo))
                    {
                        MessageBox.Show("Dados importado com sucesso.", "Importacação CSV", MessageBoxButtons.OK);
                    }
                    else
                    {
                        //TODO: 
                    }
                }
            }

            //MessageBox.Show(fileContent, "File Content at path: " + filePath, MessageBoxButtons.OK);
        }

        public override void Atualizar()
        {
            //Ignorar
        }
    }
}
