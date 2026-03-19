using Microsoft.AspNetCore.Mvc;

namespace TL.Shipay.Project.Api.Controllers
{
    [ApiController]
    [Route("api/clientes")]
    public class ClientesController : ControllerBase
    {
        private readonly ILogger<ClientesController> _logger;

        public ClientesController(ILogger<ClientesController> logger)
        {
            _logger = logger;
        }

        // POST api/<ClientesController>
        [HttpPost("validacao")]
        public async Task<IActionResult> Post([FromBody] ClienteRequest request)
        {
            return Ok();
        }
    }
}
