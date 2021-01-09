using IAudit.Teste.Application.Interfaces;
using IAudit.Teste.Application.Services;
using Microsoft.Extensions.DependencyInjection;

namespace IAudit.Teste.Infra.CrossCutting.IoC.Containers
{
    public class ApplicationServicesContainer
    {
        public static void AddDependency(IServiceCollection services)
        {
            services.AddScoped<IClienteAppService, ClienteAppService>();
            services.AddScoped<IClienteEnderecoAppService, ClienteEnderecoAppService>();
        }
    }
}
