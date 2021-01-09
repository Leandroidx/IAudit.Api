using System;
using System.Collections.Generic;
using System.Text;

namespace IAudit.Teste.Application.ViewModels
{
    public class ClienteCadastroViewModel
    {
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Email { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Descricao { get; set; }
        public List<ClienteEnderecoViewModel> ClienteEnderecos { get; set; }

    }
}
