using IAudit.Teste.Application.Interfaces;
using IAudit.Teste.Application.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace IAudit.Teste.Controllers
{
    [ApiController]
    [Route("clientes")]
    public class ClienteController : ControllerBase
    {
        private readonly IClienteAppService clienteAppService;

        public ClienteController(IClienteAppService clienteAppService)
        {
            this.clienteAppService = clienteAppService;
        }


        /// <summary>
        /// Lista Todos clientes e seus endereços
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(ClienteViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult ListarClientes()
        {
            var cliente = clienteAppService.ListarClientes();
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        /// <summary>
        /// Retorna um cliente pelo id
        /// </summary>
        /// <returns></returns>
        [HttpGet("{id}")]
        [ProducesResponseType(typeof(ClienteViewModel), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult ObterCliente(int id)
        {
            var cliente = clienteAppService.ObterCliente(id);
            if (cliente == null)
            {
                return NotFound();
            }

            return Ok(cliente);
        }

        /// <summary>
        /// Deleta um cliente
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpDelete("{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult ExcluirCliente(int id)
        {
            var retorno = clienteAppService.ExcluirCliente(id);

            if (!retorno)
            {
                return NotFound();
            }

            return Ok(retorno);
        }

        /// <summary>
        /// Realiza o cadastro de um cliente
        /// </summary>
        /// <param name="clienteViewModel"></param>
        /// <returns></returns>
        [HttpPost]
        [ProducesResponseType(typeof(int), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult CadastrarCliente(ClienteCadastroViewModel clienteViewModel)
        {
            var retorno = clienteAppService.CadastrarCliente(clienteViewModel);
            if (retorno <= 0)
            {
                return NotFound();
            }

            return Ok(retorno);
        }

        /// <summary>
        /// Realiza a edição de um cliente
        /// </summary>
        /// <param name="id"></param>
        /// <param name="clienteViewModel"></param>
        /// <returns></returns>
        [HttpPut("{id}")]
        [ProducesResponseType(typeof(bool), StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public IActionResult EditarCliente(int id, ClienteViewModel clienteViewModel)
        { 
            var retorno = clienteAppService.EditarCliente(id, clienteViewModel);
            if (!retorno)
            {
                return NotFound();
            }

            return Ok(retorno);
        }
    }
}