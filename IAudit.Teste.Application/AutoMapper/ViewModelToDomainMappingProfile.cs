using AutoMapper;
using IAudit.Teste.Application.ViewModels;
using IAudit.Teste.Infra.Domain.Models;

namespace IAudit.Teste.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {

            CreateMap<ClienteViewModel, Cliente>()
                .ForMember(c => c.Id, opts => opts.MapFrom(cv => cv.IdCliente));

            CreateMap<ClienteEnderecoViewModel, ClienteEndereco>()
                .ForMember(ce => ce.Id, opt => opt.MapFrom(cev => cev.IdClienteEndereco));
        }

    }
}
