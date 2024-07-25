using GestaoEquipamentos.WinFormsApp.ModuloCompartilhado;

namespace GestaoEquipamentos.WinFormsApp.ModuloClientes
{
    public class RepositorioClientesEmMemoria :
      BaseRepositorioEmMemoria<ClienteModel>,
      IRepositorio<ClienteModel>
    {

        public override void Semear()
        {
            ClienteModel clienteJuridico = new ClienteModel(TipoDeCliente.PessoaJuridica);
            clienteJuridico.Email = "clientejuridico@mail.com";
            clienteJuridico.Nome = "Cliente Juridico";
            clienteJuridico.CNPJ = "27.893.386/0001-64";

            Adicionar(clienteJuridico);

            ClienteModel cliente = new ClienteModel(TipoDeCliente.PessoaFisica);
            cliente.Email = "cliente@mail.com";
            cliente.Nome = "Cliente Fisico";
            cliente.CPF = "666.666.666-666";
            Adicionar(cliente);
        }
    }
}
