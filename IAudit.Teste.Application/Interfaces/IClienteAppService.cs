using IAudit.Teste.Application.ViewModels;
using System.Collections.Generic;

namespace IAudit.Teste.Application.Interfaces
{
    public interface IClienteAppService
    {
        ClienteViewModel ObterCliente(int id);

        bool EditarCliente(int id, ClienteViewModel clienteViewModel);

        int CadastrarCliente(ClienteCadastroViewModel clienteViewModel);

        IEnumerable<ClienteViewModel> ListarClientes();

        bool ExcluirCliente(int IdCliente);
    }
}
