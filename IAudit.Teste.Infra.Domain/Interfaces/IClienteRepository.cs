using IAudit.Teste.Infra.Domain.Models;
using System.Collections.Generic;

namespace IAudit.Teste.Infra.Domain.Interfaces
{
    public interface IClienteRepository
    {
        IEnumerable<Cliente> ListarClientes();
    }
}
