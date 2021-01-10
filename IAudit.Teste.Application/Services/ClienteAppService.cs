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
        private readonly IClienteEnderecoRepository clienteEnderecoRepository;

        public ClienteAppService(
                IMapper mapper,
                IClienteRepository clienteRepository,
                IClienteEnderecoRepository clienteEnderecoRepository)
        {
            this.mapper = mapper;
            this.clienteRepository = clienteRepository;
            this.clienteEnderecoRepository = clienteEnderecoRepository;
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

        public IEnumerable<ClienteEnderecoViewModel> ListarEnderecos(int idCliente)
        {
            var enderecos = clienteEnderecoRepository.ListarEnderecos(idCliente);
            return mapper.Map<IEnumerable<ClienteEnderecoViewModel>>(enderecos);
        }

        public int CadastrarEndereco(ClienteEnderecoCadastroViewModel clienteEnderecoViewModel)
        {
            var clienteEndereco = mapper.Map<ClienteEndereco>(clienteEnderecoViewModel);
            clienteEndereco = new ClienteEndereco(clienteEndereco, null, DateTime.Now, null);

            return clienteEnderecoRepository.CadastrarEndereco(clienteEndereco);
        }

        public bool ExcluirEndereco(int IdClienteEndereco)
        {
            return clienteEnderecoRepository.ExcluirEndereco(IdClienteEndereco);
        }

        public ClienteEnderecoViewModel ObterEndereco(int IdClienteEndereco)
        {
            var clienteEndereco = clienteEnderecoRepository.SelecionarEndereco(IdClienteEndereco);
            return mapper.Map<ClienteEnderecoViewModel>(clienteEndereco);
        }

        public bool EditarEndereco(int IdClienteEndereco, ClienteEnderecoViewModel clienteEnderecoViewModel)
        {
            var clienteEndereco = mapper.Map<ClienteEndereco>(clienteEnderecoViewModel);
            clienteEndereco = new ClienteEndereco(clienteEndereco, IdClienteEndereco, DateTime.Now, null);

            return clienteEnderecoRepository.EditarEndereco(IdClienteEndereco, clienteEndereco);
        }
    }
}
