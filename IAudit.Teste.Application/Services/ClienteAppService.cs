using AutoMapper;
using IAudit.Teste.Application.Interfaces;
using IAudit.Teste.Application.ViewModels;
using IAudit.Teste.Infra.Domain.Interfaces;
using IAudit.Teste.Infra.Domain.Models;
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

        public int CadastrarCliente(ClienteCadastroViewModel clienteViewModel)
        {
            var cliente = mapper.Map<Cliente>(clienteViewModel);
            cliente = new Cliente(cliente, DateTime.Now, null);

            return clienteRepository.CadastrarCliente(cliente);
        }

        public bool EditarCliente(int id, ClienteViewModel clienteViewModel)
        {
            var cliente = mapper.Map<Cliente>(clienteViewModel);
            cliente = new Cliente(cliente, DateTime.Now, null);

            return clienteRepository.EditarCliente(id, cliente);
        }

        public bool ExcluirCliente(int IdCliente)
        {
            return clienteRepository.ExcluirCliente(IdCliente);
        }

        public IEnumerable<ClienteViewModel> ListarClientes()
        {
            var clientes = clienteRepository.ListarClientes();
            return mapper.Map<IEnumerable<ClienteViewModel>>(clientes);
        }

        public ClienteViewModel ObterCliente(int id)
        {
            var cliente = clienteRepository.SelecionarCliente(id);
            return mapper.Map<ClienteViewModel>(cliente);
        }
    }
}
