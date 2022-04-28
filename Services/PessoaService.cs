using ApiTeste.Models;
using ApiTeste.Data;

namespace ApiTeste.Services
{
    public class PessoaService : IPessoaService
    {
        static Random rnd = new Random();
        public PessoaModel Get(MinhaApiDbContext context)
        {
            var pessoas = context.Pessoas.ToList();

            int randomId = rnd.Next(pessoas.Count); // => MinhaApiDbContext context assim que eu acesso meu banco de dados.
            if (randomId == 0)
                randomId++;

            var pessoa = pessoas.FirstOrDefault(x => x.Id == randomId);

            return pessoa;
        }

        public List<PessoaModel> List(MinhaApiDbContext context)
        {
            var pessoas = context.Pessoas.ToList();
            return pessoas;
        }
    }
}
