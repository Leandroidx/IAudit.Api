using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IAudit.Teste.Infra.Domain.Models
{
    public class ClienteEndereco
    {

        public ClienteEndereco()
        {
            this.DataCriacao = this.DataCriacao;
            this.DataAlteracao = DateTime.Now;
            this.Ativo = true;
        }

        public ClienteEndereco(ClienteEndereco clienteEndereco,
            int? idCliente,
            DateTime? dataCriacao,
            DateTime? dataAlteracao)
        {
            this.Id = clienteEndereco.Id;
            this.IdCliente = idCliente ?? clienteEndereco.IdCliente;
            this.Cep = clienteEndereco.Cep;
            this.Endereco = clienteEndereco.Endereco;
            this.Bairro = clienteEndereco.Bairro;
            this.Cidade = clienteEndereco.Cidade;
            this.Estado = clienteEndereco.Estado;
            this.Pais = clienteEndereco.Pais;
            this.Complemento = clienteEndereco.Complemento;
            this.DataCriacao = dataCriacao ?? this.DataCriacao;
            this.DataAlteracao = dataAlteracao ?? this.DataAlteracao;
            this.Ativo = true;
        }

        public int Id { get; set; }
        public int IdCliente { get; private set; }
        public string Cep { get; private set; }
        public string Endereco { get; private set; }
        public string Bairro { get; private set; }
        public string Cidade { get; private set; }
        public string Estado { get; private set; }
        public string Pais { get; private set; }
        public string Complemento { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime? DataAlteracao { get; private set; }
        public bool Ativo { get; private set; }

        [NotMapped]
        public virtual Cliente Cliente { get; private set; }
    }
}
