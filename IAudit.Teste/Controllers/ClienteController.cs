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
    }
}