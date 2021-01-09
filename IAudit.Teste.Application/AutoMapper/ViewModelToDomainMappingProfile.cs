using AutoMapper;
using IAudit.Teste.Application.ViewModels;
using IAudit.Teste.Infra.Domain.Models;
using System;

namespace IAudit.Teste.Application.AutoMapper
{
    public class ViewModelToDomainMappingProfile : Profile
    {
        public ViewModelToDomainMappingProfile()
        {

            CreateMap<ClienteViewModel, Cliente>()
                .ForMember(c => c.Id, opts => opts.MapFrom(cv => cv.IdCliente))
                .ForMember(c => c.DataAlteracao, opts => opts.MapFrom(cv => DateTime.Now))
                .ForMember(c => c.DataCriacao, opts => opts.Ignore())
                .ForMember(c => c.ClienteEnderecos, opts => opts.MapFrom(cv => cv.ClienteEnderecos));

            CreateMap<ClienteEnderecoViewModel, ClienteEndereco>()
                .ForMember(ce => ce.Id, opt => opt.MapFrom(cev => cev.IdClienteEndereco))
                .ForMember(c => c.DataAlteracao, opts => opts.MapFrom(cv => DateTime.Now))
                .ForMember(c => c.DataCriacao, opts => opts.Ignore());

            CreateMap<ClienteCadastroViewModel, Cliente>()
                .ForMember(c => c.DataAlteracao, opts => opts.MapFrom(cv => DateTime.Now))
                .ForMember(c => c.DataCriacao, opts => opts.Ignore())
                .ForMember(c => c.ClienteEnderecos, opts => opts.MapFrom(cv => cv.ClienteEnderecos));

            CreateMap<ClienteEnderecoCadastroViewModel, ClienteEndereco>()
                .ForMember(c => c.DataAlteracao, opts => opts.MapFrom(cv => DateTime.Now))
                .ForMember(c => c.DataCriacao, opts => opts.Ignore());
        }

    }
}
