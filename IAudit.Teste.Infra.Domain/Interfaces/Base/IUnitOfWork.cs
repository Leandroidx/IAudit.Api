using System;

namespace IAudit.Teste.Infra.Domain.Interfaces.Base
{
    public interface IUnitOfWork : IDisposable
    {
        bool SalvarAlteracoes();
    }
}
