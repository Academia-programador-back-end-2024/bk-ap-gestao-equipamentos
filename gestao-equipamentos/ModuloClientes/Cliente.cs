using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloClientes
{

    public enum TipoDeCliente
    {
        PessoaFisica = 0,
        PessoaJuridica = 1
    }

    public class ClienteModel : BaseModel
    {
        public ClienteModel(TipoDeCliente tipoDeCliente)
        {
            TipoCliente = tipoDeCliente;
        }

        public string Nome { get; set; }
        public string Localizacao { get; set; }
        public string Email { get; set; }
        public string Telefone { get; set; }
        public string Endereço { get; set; }
        public string DetalhesContrato { get; set; }
        public TipoDeCliente TipoCliente { get; set; }
        public string CPF { get; set; }
        public string CNPJ { get; set; }

        public override string ToString()
        {
            var codigo = TipoCliente == TipoDeCliente.PessoaFisica ? CPF : CNPJ;
            return $"{Nome}¬{codigo}¬{Email}";
        }

        public override string Validar()
        {
            string error = string.Empty;

            if (string.IsNullOrEmpty(Nome))
            {
                error += "Nome é obrigatorio.";
            }

            if (string.IsNullOrEmpty(Email))
            {
                error += "Email é obrigatorio.";
            }

            if (this.TipoCliente.Equals(TipoDeCliente.PessoaFisica) && string.IsNullOrEmpty(CPF))
            {
                error += "CPF é obrigatorio.";
            }

            if (this.TipoCliente.Equals(TipoDeCliente.PessoaJuridica) && string.IsNullOrEmpty(CNPJ))
            {
                error += "CNPJ é obrigatorio.";
            }

            return error;
        }
    }
}
