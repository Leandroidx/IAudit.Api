using IAudit.Teste.Infra.Data.Context;
using IAudit.Teste.Infra.Domain.Interfaces;
using IAudit.Teste.Infra.Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace IAudit.Teste.Infra.Data.Repository
{
    public class ClienteRepository : Repository<Cliente>, IClienteRepository
    {
        public ClienteRepository(IAuditContext context) : base(context)
        {
        }

        public Cliente SelecionarCliente(int id)
        {
            return DbSet.Where(c => c.Id == id && c.Ativo)
                                .Include(ce => ce.ClienteEnderecos)
                                .FirstOrDefault();
        }

        public IEnumerable<Cliente> ListarClientes()
        {
            return DbSet.Where(c => c.Ativo)
                                .Include(ce => ce.ClienteEnderecos)
                                .ToList();
        }

        public int CadastrarCliente(Cliente cliente)
        {
            this.Adicionar(cliente);
            this.SalvarAlteracoes();

            return cliente.Id;
        }

        public bool ExcluirCliente(int id)
        {
            var cliente = DbSet
                            .Where(c => c.Id == id && c.Ativo)
                            .Include(c=> c.ClienteEnderecos)
                            .FirstOrDefault();

            this.Remover(cliente);

            return this.SalvarAlteracoes() > 0;
        }

        public bool EditarCliente(int id, Cliente cliente)
        {
            var clienteExiste = DbSet.Any(c => c.Id == id && c.Ativo);

            if (clienteExiste && cliente.Id == id)
            {
                this.Atualizar(cliente);
                return this.SalvarAlteracoes() > 0;
            }

            return false;
        }


    }
}
