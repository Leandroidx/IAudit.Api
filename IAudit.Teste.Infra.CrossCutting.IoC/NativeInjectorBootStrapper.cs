
using IAudit.Teste.Infra.CrossCutting.IoC.Containers;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using AutoMapper;
using IAudit.Teste.Application.AutoMapper;

namespace IAudit.Teste.Infra.CrossCutting.IoC
{
    public static class NativeInjectorBootStrapper
    {
        public static void RegisterDependency(this IServiceCollection services, IConfiguration configuration)
        {

            RepositoriesContainer.AddDependency(services, configuration);

            ApplicationServicesContainer.AddDependency(services);

            services.AddSingleton<IMapper>(new Mapper(AutoMapperConfig.RegisterMappings()));
        }
    }
}
