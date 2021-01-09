using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

namespace IAudit.Teste.Infra.Domain.Models
{
    public class Cliente
    {

        public Cliente()
        {
            this.DataCriacao = this.DataCriacao;
            this.DataAlteracao = DateTime.Now;
            this.Ativo = true;
        }

        public Cliente(Cliente cliente, 
            DateTime? dataCriacao,
            DateTime? dataAlteracao)
        {

            this.Id = cliente.Id;
            this.Nome = cliente.Nome;
            this.Cpf = cliente.Cpf;
            this.Email = cliente.Email;
            this.DataNascimento = cliente.DataNascimento;
            this.Descricao = cliente.Descricao;
            this.DataCriacao = dataCriacao ?? this.DataCriacao;
            this.DataAlteracao = dataAlteracao ?? this.DataAlteracao;
            this.Ativo = true;

            var clienteEnderecos = new List<ClienteEndereco>();
            foreach (var ce in cliente.ClienteEnderecos)
            {
                var clienteEndereco = new ClienteEndereco(ce, cliente.Id, DateTime.Now, null);
                clienteEnderecos.Add(clienteEndereco);
            }

            this.ClienteEnderecos = clienteEnderecos;  
        }

        public int Id { get; private set; }
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Descricao { get; private set; }
        public virtual ICollection<ClienteEndereco> ClienteEnderecos { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime? DataAlteracao { get; private set; }
        public bool Ativo { get; private set; }
    }



}
