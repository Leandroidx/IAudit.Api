using IAudit.Teste.Infra.Domain.Models;
using System.Collections.Generic;

namespace IAudit.Teste.Infra.Domain.Interfaces
{
    public interface IClienteEnderecoRepository
    {
        ClienteEndereco SelecionarEndereco(int id);
        IEnumerable<ClienteEndereco> ListarEnderecos(int idCliente);
        bool EditarEndereco(int id, ClienteEndereco endereco);
        int CadastrarEndereco(ClienteEndereco endereco);
        bool ExcluirEndereco(int id);
    }
}
