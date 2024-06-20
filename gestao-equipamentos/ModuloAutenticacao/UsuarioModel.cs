using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloAutenticacao
{
    public class UsuarioModel : BaseModel
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public bool IsAdmin { get; set; }

        public override string Validar()
        {
            string error = string.Empty;

            if (string.IsNullOrEmpty(Login))
            {
                error += "O campo 'Login' é obrigatório \n";
            }

            return error;
        }
    }
}
