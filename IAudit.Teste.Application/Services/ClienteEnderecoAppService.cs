using IAudit.Teste.Application.Interfaces;
using IAudit.Teste.Application.ViewModels;
using IAudit.Teste.Infra.Domain.Models;
using System;
using System.Collections.Generic;

namespace IAudit.Teste.Application.Services
{
    public class ClienteEnderecoAppService : IClienteEnderecoAppService
    {
        public bool CadastrarClienteEndereco(ClienteEnderecoViewModel cliente)
        {
            throw new NotImplementedException();
        }

        public bool ExcluirClienteEndereco(int IdClienteEndereco)
        {
            throw new NotImplementedException();
        }

        public List<ClienteEnderecoViewModel> ListarClienteEnderecos(int idCliente)
        {
            throw new NotImplementedException();
        }

        public ClienteEnderecoViewModel ObterClienteEndereco()
        {
            throw new NotImplementedException();
        }
    }
}
