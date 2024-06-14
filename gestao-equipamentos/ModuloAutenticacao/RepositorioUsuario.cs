
namespace GestaoEquipamentos.WinFormsApp.ModuloAutenticacao
{
    //Faz o crud
    public class RepositorioUsuario
    {
        private List<Usuario> Usuarios { get; set; }

        public RepositorioUsuario()
        {
            Usuarios = new List<Usuario>();
            Semear();
        }

        public Usuario EncontreUsuarioPorLogin(string login)
        {
            return Usuarios.Find(u => u.Login == login);
        }

        public void CriarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        private void Semear()
        {
            Usuarios.Add(new Usuario { Login = "admin", Senha = "admin" });
        }

        public List<Usuario> ObterUsuarios()
        {
            return Usuarios;
        }
    }
}
