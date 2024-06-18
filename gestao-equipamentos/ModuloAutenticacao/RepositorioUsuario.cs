
namespace GestaoEquipamentos.WinFormsApp.ModuloAutenticacao
{
    //Faz o crud
    public class RepositorioUsuario
    {
        private List<UsuarioModel> Usuarios { get; set; }

        public RepositorioUsuario()
        {
            Usuarios = new List<UsuarioModel>();
            Semear();
        }

        public UsuarioModel EncontreUsuarioPorLogin(string login)
        {
            return Usuarios.Find(u => u.Login == login);
        }

        public void CriarUsuario(UsuarioModel usuario)
        {
            Usuarios.Add(usuario);
        }

        private void Semear()
        {
            Usuarios.Add(new UsuarioModel { Login = "admin", Senha = "admin" });
        }

        public List<UsuarioModel> ObterUsuarios()
        {
            return Usuarios;
        }
    }
}
