using Microsoft.AspNetCore.Mvc;

namespace ApiTeste.Controllers
{
    [ApiController]
    public class VeiculoController : ControllerBase
    {
        [HttpGet("/veiculo")]
        public IActionResult Get()
            => Ok("Veiculo do Get é um Gol");

        [HttpPost("/veiculo")]
        public IActionResult Post()
            => Ok("Veiculo do Post é um Fiat");

        [HttpDelete("/veiculo")]
        public IActionResult Delete()
            => Ok("Veiculo do Delete é um Volkswagen");
    }
}
