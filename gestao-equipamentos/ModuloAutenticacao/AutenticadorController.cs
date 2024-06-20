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

            UsuarioModel? usuario = new UsuarioModel()
            {
                Login = login,
                Senha = senha
            };

            if (usuario.Validar() != String.Empty)
            {
                return false;
            }

            usuario = RepositorioUsuario.EncontreUsuarioPorLogin(login);

            if (usuario != null && usuario.Senha.Equals(senha))
            {
                return true;
            }

            throw new AuthenticationException();
        }

        public List<UsuarioModel> ObterUsuarios()
        {
            return RepositorioUsuario.ObterUsuarios();
        }
    }

    public class AuthenticationException : Exception
    {
        public AuthenticationException(string message = "Usuário ou senha inválidos") : base(message)
        {

        }
    }
}
