using IAudit.Teste.Infra.Data.Context;
using IAudit.Teste.Infra.Domain.Interfaces;
using IAudit.Teste.Infra.Domain.Models;
using System.Collections.Generic;
using System.Linq;

namespace IAudit.Teste.Infra.Data.Repository
{
    public class ClienteEnderecoRepository : Repository<ClienteEndereco>, IClienteEnderecoRepository
    {
        public ClienteEnderecoRepository(IAuditContext context) : base(context)
        {
        }
        public ClienteEndereco SelecionarEndereco(int id)
        {
            return DbSet.Where(c => c.Id == id && c.Ativo)
                        .FirstOrDefault();
        }

        public IEnumerable<ClienteEndereco> ListarEnderecos(int idCliente)
        {
            return DbSet.Where(c => c.Ativo && c.IdCliente == idCliente)
                        .ToList();
        }

        public bool ExcluirEndereco(int id)
        {
            var endereco = DbSet
                            .Where(c => c.Id == id && c.Ativo)
                            .FirstOrDefault();

            this.Remover(endereco);

            return this.SalvarAlteracoes() > 0;
        }

        public bool EditarEndereco(int id, ClienteEndereco endereco)
        {
            var enderecoExiste = DbSet.Any(c => c.Id == id && c.Ativo);

            if (enderecoExiste && endereco.Id == id)
            {
                this.Atualizar(endereco);
                return this.SalvarAlteracoes() > 0;
            }

            return false;
        }

        public int CadastrarEndereco(ClienteEndereco endereco)
        {
            this.Adicionar(endereco);
            this.SalvarAlteracoes();

            return endereco.Id;
        }
    }
}
