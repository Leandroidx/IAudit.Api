using AutoMapper;
using IAudit.Teste.Application.Interfaces;
using IAudit.Teste.Application.ViewModels;
using IAudit.Teste.Infra.Domain.Interfaces;
using System;
using System.Collections.Generic;

namespace IAudit.Teste.Application.Services
{
    public class ClienteAppService : IClienteAppService
    {
        private readonly IMapper mapper;
        private readonly IClienteRepository clienteRepository;

        public ClienteAppService(
                IMapper mapper,
                IClienteRepository clienteRepository)
        {
            this.mapper = mapper;
            this.clienteRepository = clienteRepository;
        }

        public bool CadastrarCliente(ClienteViewModel cliente)
        {
            throw new NotImplementedException();
        }

        public bool ExcluirCliente(int IdCliente)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ClienteViewModel> ListarClientes()
        {
            var clientes = clienteRepository.ListarClientes();
            return mapper.Map<IEnumerable<ClienteViewModel>>(clientes);
        }

        public ClienteViewModel ObterCliente()
        {
            throw new NotImplementedException();
        }
    }
}
