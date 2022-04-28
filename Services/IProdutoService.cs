using ApiTeste.Data;
using ApiTeste.Models;

namespace ApiTeste.Services
{
    public interface IProdutoService
    {
        public ProdutoModel Get(string? nome, int? quantidade, MinhaApiDbContext context);
    }
}
