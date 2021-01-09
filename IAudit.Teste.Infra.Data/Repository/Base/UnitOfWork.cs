using IAudit.Teste.Infra.Data.Context;
using IAudit.Teste.Infra.Domain.Interfaces.Base;

namespace IAudit.Teste.Infra.Data.Repository.Base
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IAuditContext iAuditContext;

        public UnitOfWork(IAuditContext iAuditContext)
        {
            this.iAuditContext = iAuditContext;
        }

        public bool SalvarAlteracoes()
        {
            return iAuditContext.SaveChanges() > 0;
        }

        public void Dispose()
        {
            iAuditContext.Dispose();
        }
    }
}
