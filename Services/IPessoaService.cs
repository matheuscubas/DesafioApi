using ApiTeste.Data;
using ApiTeste.Models;

namespace ApiTeste.Services
{
    public interface IPessoaService
    {
        public PessoaModel? Get(MinhaApiDbContext context);
        public List<PessoaModel> List(MinhaApiDbContext context); 
    }
}
