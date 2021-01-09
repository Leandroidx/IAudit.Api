using IAudit.Teste.Infra.Domain.Models;
using System.Collections.Generic;

namespace IAudit.Teste.Infra.Domain.Interfaces
{
    public interface IClienteRepository
    {
        Cliente SelecionarCliente(int id);

        IEnumerable<Cliente> ListarClientes();

        bool ExcluirCliente(int id);

        bool EditarCliente(int id, Cliente cliente);

        int CadastrarCliente(Cliente cliente);
    }
}
