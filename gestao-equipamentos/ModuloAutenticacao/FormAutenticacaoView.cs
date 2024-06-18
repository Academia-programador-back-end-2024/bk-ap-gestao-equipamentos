using WinFormsApp1;

namespace GestaoEquipamentos.WinFormsApp.ModuloAutenticacao
{
<<<<<<< HEAD:gestao-equipamentos/ModuloAutenticacao/FormAutenticacaoView.cs
    public partial class FormAutenticacaoView : Form
=======
    //VIEW
    public partial class FormAutenticacao : Form
>>>>>>> 29bcd8ca552f1751a45775a739e4fdb39a17cb3e:gestao-equipamentos/ModuloAutenticacao/FormAutenticacao.cs
    {
        //Controllador
        AutenticadorController AutenticadorController { get; set; }
<<<<<<< HEAD:gestao-equipamentos/ModuloAutenticacao/FormAutenticacaoView.cs
        public FormAutenticacaoView()
=======

        public FormAutenticacao()
>>>>>>> 29bcd8ca552f1751a45775a739e4fdb39a17cb3e:gestao-equipamentos/ModuloAutenticacao/FormAutenticacao.cs
        {
            InitializeComponent();
            AutenticadorController = new AutenticadorController();

            //dataGridView1.DataSource = AutenticadorController.ObterUsuarios();
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
