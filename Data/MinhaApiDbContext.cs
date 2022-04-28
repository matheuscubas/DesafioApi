using ApiTeste.Models;
using Microsoft.EntityFrameworkCore;

namespace ApiTeste.Data
{
    public class MinhaApiDbContext : DbContext
    {
        public MinhaApiDbContext(DbContextOptions<MinhaApiDbContext> options) : base(options)
        {
        }

        public DbSet<PessoaModel> Pessoas { get; set; }
        public DbSet<ProdutoModel> Produtos { get; set; }
    }
}
