using IAudit.Teste.Application.ViewModels;
using IAudit.Teste.Infra.Domain.Models;
using System.Collections.Generic;

namespace IAudit.Teste.Application.Interfaces
{
    public interface IClienteEnderecoAppService
    {
        ClienteEnderecoViewModel ObterClienteEndereco();

        bool CadastrarClienteEndereco(ClienteEnderecoViewModel cliente);

        List<ClienteEnderecoViewModel> ListarClienteEnderecos(int idCliente);

        bool ExcluirClienteEndereco(int IdClienteEndereco);
    }
}
