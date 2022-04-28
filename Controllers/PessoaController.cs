using ApiTeste.Data;
using ApiTeste.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTeste.Controllers
{
    [ApiController]
    public class PessoaController : ControllerBase
    {
        [HttpGet("pessoa")]
        public IActionResult Get(
            [FromServices] MinhaApiDbContext context,
            [FromServices] IPessoaService service)
        {
            var pessoa = service.Get(context);
            return Ok(pessoa);
        }

        [HttpGet("/pessoas")]
        public IActionResult GetAll(
            [FromServices] MinhaApiDbContext context,
            [FromServices] IPessoaService service)
        {
            var pessoas = service.List(context);
            return Ok(pessoas);
        }
    }
}
