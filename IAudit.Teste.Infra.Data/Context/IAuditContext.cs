using IAudit.Teste.Infra.Data.Mappings;
using IAudit.Teste.Infra.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace IAudit.Teste.Infra.Data.Context
{
    public class IAuditContext : DbContext
    {
        public IAuditContext(DbContextOptions<IAuditContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Cliente{ get; set; }
        public DbSet<ClienteEndereco> ClienteEndereco { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ClienteMap());
            modelBuilder.ApplyConfiguration(new ClienteEnderecoMap());
        }
    }
}
