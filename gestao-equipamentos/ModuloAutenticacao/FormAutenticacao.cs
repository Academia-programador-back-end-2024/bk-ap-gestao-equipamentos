using WinFormsApp1;

namespace GestaoEquipamentos.WinFormsApp.ModuloAutenticacao
{
    public partial class FormAutenticacao : Form
    {
        AutenticadorController AutenticadorController { get; set; }
        public FormAutenticacao()
        {
            InitializeComponent();
            AutenticadorController = new AutenticadorController();
            dataGridView1.DataSource = AutenticadorController.ObterUsuarios();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string login = txtLogin.Text;
            string senha = txtSenha.Text;

            try
            {
                if (AutenticadorController.Autenticar(login, senha))
                {
                    Hide();
                    GestaoEquipamentosForm gestaoEquipamentosForm = new GestaoEquipamentosForm();
                    gestaoEquipamentosForm.ShowDialog(this);

                    Close();
                }
            }
            catch (Exception ex)
            {
                toolStripStatusLabelInfo.Text = ex.Message;
            }

        }
    }
}
