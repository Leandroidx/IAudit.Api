

using IAudit.Teste.Infra.Data.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using IAudit.Teste.Infra.Domain.Interfaces.Base;
using IAudit.Teste.Infra.Data.Repository.Base;
using IAudit.Teste.Infra.Domain.Interfaces;
using IAudit.Teste.Infra.Data.Repository;

namespace IAudit.Teste.Infra.CrossCutting.IoC.Containers
{
    public class RepositoriesContainer
    {
        public static void AddDependency(IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<IAuditContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("IAuditDb")));

            services.AddScoped<IUnitOfWork, UnitOfWork>();

            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IClienteEnderecoRepository, ClienteEnderecoRepository>();
        }

    }
}
