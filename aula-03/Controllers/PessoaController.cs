using aula_03.Data;
using aula_03.Models;
using Microsoft.AspNetCore.Mvc;

namespace aula_03.Controllers
{
    [ApiController]
    [Route("pessoas")]
    public class PessoaController : ControllerBase
    {
        MeuAppDbContext context;
        public PessoaController()
        {
            context = new MeuAppDbContext();
        }

        [HttpGet]
        public List<Pessoa> Listar()
        {
            return context.Pessoas.ToList();
        }

        [HttpPost]
        public void Criar(Pessoa model)
        {
            context.Pessoas.Add(model);
            context.SaveChanges();
        }
    }
}