
namespace GestaoEquipamentos.WinFormsApp.ModuloAutenticacao
{
    //Faz o crud
    public class RepositorioUsuario
    {
<<<<<<< HEAD
        private List<UsuarioModel> Usuarios { get; set; }
=======
        private List<Usuario> Usuarios { get; set; }
        // Usuario[]
>>>>>>> 29bcd8ca552f1751a45775a739e4fdb39a17cb3e

        public RepositorioUsuario()
        {
            Usuarios = new List<UsuarioModel>();
            Semear();
        }

        public UsuarioModel EncontreUsuarioPorLogin(string login)
        {
            for (int i = 0; i < Usuarios.Count; i++)
            {
                Usuario u = Usuarios[i];
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
<<<<<<< HEAD
            Usuarios.Add(new UsuarioModel { Login = "admin", Senha = "admin" });
=======
            Usuarios.Add(
                    new Usuario
                    {
                        Login = "admin",
                        Senha = "admin",
                        IsAdmin = true
                    });
>>>>>>> 29bcd8ca552f1751a45775a739e4fdb39a17cb3e
        }

        public List<UsuarioModel> ObterUsuarios()
        {
            return Usuarios;
        }
    }
}
