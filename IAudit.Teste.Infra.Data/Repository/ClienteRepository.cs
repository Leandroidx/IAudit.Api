using IAudit.Teste.Infra.Data.Context;
using IAudit.Teste.Infra.Domain.Interfaces;
using IAudit.Teste.Infra.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace IAudit.Teste.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(IAuditContext context) : base(context)
        {
        }

        public IEnumerable<Cliente> ListarClientes()
        {
            return DbSet.Where(c => c.Ativo)
                    .Include(ce => ce.ClienteEndereco)
                    .ToList();
        }
    }
}
