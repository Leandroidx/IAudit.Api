using AutoMapper;
using IAudit.Teste.Application.ViewModels;
using IAudit.Teste.Infra.Domain.Models;

namespace IAudit.Teste.Application.AutoMapper
{
    public class DomainToViewModelMappingProfile : Profile
    {

        public DomainToViewModelMappingProfile()
        {
            AllowNullCollections = true;
            AllowNullDestinationValues = true;

            CreateMap<Cliente, ClienteViewModel>()
                .ForMember(c => c.IdCliente, opts => opts.MapFrom(cvm => cvm.Id))
                .ForMember(c => c.Nome, opts => opts.MapFrom(cvm => cvm.Nome));

            CreateMap<ClienteEndereco, ClienteEnderecoViewModel>()
                .ForMember(c => c.IdClienteEndereco, opts => opts.MapFrom(cvm => cvm.Id))
                .ForMember(c => c.Endereco, opts => opts.MapFrom(cvm => cvm.Endereco));
        }
    }
}
