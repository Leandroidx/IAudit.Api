﻿using System;

namespace IAudit.Teste.Infra.Domain.Interfaces.Base
{
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        int SalvarAlteracoes();

        void Adicionar(TEntity obj);

        void Atualizar(TEntity obj);

        void Remover(TEntity obj);

    }
}
