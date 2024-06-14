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

            throw new AuthenticationException("Usuário ou senha inválidos");
        }

        public List<Usuario> ObterUsuarios()
        {
            return RepositorioUsuario.ObterUsuarios();
        }
    }

    public class AuthenticationException : Exception
    {
        public AuthenticationException(string message) : base(message)
        {
        }
    }
}
