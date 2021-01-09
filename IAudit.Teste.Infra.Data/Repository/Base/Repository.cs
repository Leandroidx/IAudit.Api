using IAudit.Teste.Infra.Data.Context;
using IAudit.Teste.Infra.Domain.Interfaces.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace IAudit.Teste.Infra.Data.Repository
{
    public abstract class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly IAuditContext DbContext;

        protected readonly DbSet<TEntity> DbSet;

        public Repository(IAuditContext context)
        {
            DbContext = context;
            DbSet = DbContext.Set<TEntity>();
        }

        public void Dispose()
        {
            DbContext.Dispose();
            GC.SuppressFinalize(this);
        }

        public int SalvarAlteracoes()
        {
            return DbContext.SaveChanges();
        }

        public virtual void Adicionar(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public virtual void Atualizar(TEntity obj)
        {
            DbSet.Attach(obj);
            DbContext.Entry(obj).State = EntityState.Modified;
        }

        public virtual void Remover(TEntity obj)
        {
            DbSet.Remove(obj);
        }

    }
}
