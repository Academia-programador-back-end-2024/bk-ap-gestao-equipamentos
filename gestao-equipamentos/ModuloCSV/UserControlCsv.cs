namespace GestaoEquipamentos.WinFormsApp.ModuloCSV
{
    public partial class UserControlCsv : UserControl
    {
        IImportar Importar { get; set; }
        public UserControlCsv(IImportar importar)
        {
            InitializeComponent();
            Importar = importar;
        }

        private void Exportar_Click(object sender, EventArgs e)
        {

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
    }
}
