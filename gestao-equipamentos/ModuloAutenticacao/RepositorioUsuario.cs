
namespace GestaoEquipamentos.WinFormsApp.ModuloAutenticacao
{
    //Faz o crud
    public class RepositorioUsuario
    {
        private List<Usuario> Usuarios { get; set; }
        // Usuario[]

        public RepositorioUsuario()
        {
            Usuarios = new List<Usuario>();
            Semear();
        }

        public Usuario EncontreUsuarioPorLogin(string login)
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

        public void CriarUsuario(Usuario usuario)
        {
            Usuarios.Add(usuario);
        }

        private void Semear()
        {
            Usuarios.Add(
                    new Usuario
                    {
                        Login = "admin",
                        Senha = "admin",
                        IsAdmin = true
                    });
        }

        public List<Usuario> ObterUsuarios()
        {
            return Usuarios;
        }
    }
}
