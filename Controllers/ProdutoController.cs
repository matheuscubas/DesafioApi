using ApiTeste.Data;
using ApiTeste.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiTeste.Controllers
{
    [ApiController]
    public class ProdutoController : ControllerBase
    {
        private IProdutoService _produtoService;
        public ProdutoController(IProdutoService produto) // => utilizando injeção de dependencia vi construtor.
        {
            _produtoService = produto;   
        }

        [HttpGet("informaproduto")]
        public IActionResult Get(
            string? nome, int? quantidade,
            [FromServices] MinhaApiDbContext context // => injeção de dependencia via método.
            //[FromServices] IProdutoService service => forma sem usar injeção de dependencia.
            )
        {
            if(nome == null || quantidade == null)
                return BadRequest("Você deve informar nome e quantidade do produto!");

            var produto = _produtoService.Get(nome, quantidade, context);

            if (produto == null)
                return BadRequest($"O produto {nome} não existe no nosso banco de dados");

            return Ok(produto);
        }
    }
}
