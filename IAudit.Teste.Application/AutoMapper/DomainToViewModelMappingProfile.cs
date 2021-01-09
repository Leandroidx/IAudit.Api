using AutoMapper;
using IAudit.Teste.Application.ViewModels;
using IAudit.Teste.Infra.Domain.Models;
using System.Linq;

namespace IAudit.Teste.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public DomainToViewModelMappingProfile()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;

            CreateMap<Cliente, ClienteViewModel>()
                .ForMember(cvm => cvm.IdCliente, opts => opts.MapFrom(c => c.Id))
                .ForMember(cvm => cvm.ClienteEnderecos, opts => opts.MapFrom(c => c.ClienteEnderecos.ToList()));

            CreateMap<ClienteEndereco, ClienteEnderecoViewModel>()
                .ForMember(cvm => cvm.IdClienteEndereco, opts => opts.MapFrom(c => c.Id));
        }
    }
}
