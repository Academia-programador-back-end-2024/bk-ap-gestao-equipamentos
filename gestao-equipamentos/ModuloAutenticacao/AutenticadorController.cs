namespace GestaoEquipamentos.WinFormsApp.ModuloAutenticacao
{
    public class AutenticadorController
    {
        private readonly RepositorioUsuario RepositorioUsuario;

        public AutenticadorController()
        {
            RepositorioUsuario = new RepositorioUsuario();
        }

        public bool Autenticar(string login, string senha)
        {
            Usuario? usuario = RepositorioUsuario.EncontreUsuarioPorLogin(login);

            if (usuario != null && usuario.Senha.Equals(senha))
            {
                return true;
            }

            return false;
        }

        public List<Usuario> ObterUsuarios()
        {
            return RepositorioUsuario.ObterUsuarios();
        }
    }
}
