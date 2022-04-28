using ApiTeste.Data;
using ApiTeste.Models;

namespace ApiTeste.Services
{
    public class ProdutoService : IProdutoService
    {
        public ProdutoModel? Get(string? nome, int? quantidade, MinhaApiDbContext context)
        {
            var produto = context.Produtos.ToList().Find(x => x.Nome == nome && x.Quantidade == quantidade);
            return produto;
        }
    }
}
