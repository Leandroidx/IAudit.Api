using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace IAudit.Teste.Infra.Domain.Models
{
    public class ClienteEndereco : Entity
    {
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
