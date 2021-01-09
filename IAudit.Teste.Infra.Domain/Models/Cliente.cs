using System;
using System.Collections.Generic;

namespace IAudit.Teste.Infra.Domain.Models
{
    public class Cliente : Entity
    {
        public string Nome { get; private set; }
        public string Cpf { get; private set; }
        public string Email { get; private set; }
        public DateTime DataNascimento { get; private set; }
        public string Descricao { get; private set; }
        public virtual ICollection<ClienteEndereco> ClienteEndereco { get; private set; }
        public DateTime DataCriacao { get; private set; }
        public DateTime? DataAlteracao { get; private set; }
        public bool Ativo { get; private set; }
    }
}
