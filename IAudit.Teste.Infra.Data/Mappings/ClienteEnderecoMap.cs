using IAudit.Teste.Infra.Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IAudit.Teste.Infra.Data.Mappings
{
    class ClienteEnderecoMap : IEntityTypeConfiguration<ClienteEndereco>
    {

        public void Configure(EntityTypeBuilder<ClienteEndereco> builder)
        {

            builder.ToTable("ClienteEndereco");

            builder.HasKey(c => c.Id);

            builder.HasOne(c => c.Cliente)
                   .WithMany(c => c.ClienteEndereco)
                   .HasForeignKey(c => c.IdCliente);
        }
    }
}
