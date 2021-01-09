using IAudit.Teste.Infra.Data.Context;
using IAudit.Teste.Infra.Domain.Interfaces;
using IAudit.Teste.Infra.Domain.Models;

namespace IAudit.Teste.Infra.Data.Repository
{
    public class ClienteEnderecoRepository : Repository<ClienteEndereco>, IClienteEnderecoRepository
    {
        public ClienteEnderecoRepository(IAuditContext context) : base(context)
        {
        }
    }
}
