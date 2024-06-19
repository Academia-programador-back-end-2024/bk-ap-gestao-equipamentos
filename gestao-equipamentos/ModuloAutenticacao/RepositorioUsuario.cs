
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
            for (int i = 0; i < Usuarios.Count; i++)
            {
                UsuarioModel u = Usuarios[i];
                if (u.Login == login)
                {
                    return u;
                }
            }

            return null;

            //foreach (Usuario u in Usuarios)
            //return Usuarios.Find(u => u.Login == login);
            //$"select * from TbUsers where login = '{login}'"
        }

        public void CriarUsuario(UsuarioModel usuario)
        {
            Usuarios.Add(usuario);
        }

        private void Semear()
        {
            Usuarios.Add(
                    new UsuarioModel
                    {
                        Login = "admin",
                        Senha = "admin",
                        IsAdmin = true
                    });
        }

        public List<UsuarioModel> ObterUsuarios()
        {
            return Usuarios;
        }
    }
}
