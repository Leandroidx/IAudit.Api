using IAudit.Teste.Application.ViewModels;
using System.Collections.Generic;

namespace IAudit.Teste.Application.Interfaces
{
    public interface IClienteAppService
    {
        ClienteViewModel ObterCliente();

        bool CadastrarCliente(ClienteViewModel cliente);

        IEnumerable<ClienteViewModel> ListarClientes();

        bool ExcluirCliente(int IdCliente);
    }
}
