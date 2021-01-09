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

            builder.HasKey(ce => ce.Id);

            builder.HasOne(ce => ce.Cliente)
                   .WithMany(ce => ce.ClienteEnderecos)
                   .HasForeignKey(ce => ce.IdCliente);
        }
    }
}
