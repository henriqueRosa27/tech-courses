using aula_02.Models;
using Microsoft.AspNetCore.Mvc;

namespace aula_02.Controllers
{
    [ApiController]
    [Route("pessoas")]
    public class PessoaController : ControllerBase
    {
        static  List<Pessoa> pessoas = new List<Pessoa>();

        [HttpGet]
        public  List<Pessoa> Get()
        {
            return pessoas;
        }

        [HttpPost]
        public IActionResult Criar(Pessoa model)
        {
            foreach(var pessoa in pessoas)
            {
                if(pessoa.CPF == model.CPF)
                {
                    return BadRequest("CPF já em uso");
                }
            }
            if(model.Idade < 18 || model.Idade > 50)
            {
                return BadRequest("Idade inválida");
            }

            pessoas.Add(model);
            return Ok(model);
        }

        [HttpPut]
        public IActionResult Alterar(Pessoa model)
        {
            bool naoExiste = true;
            foreach(var pessoa in pessoas)
            {
                if(pessoa.CPF == model.CPF)
                {
                    pessoa.Nome = model.Nome;
                    pessoa.Idade = model.Idade;
                    naoExiste = false;
                }
            }

            if(naoExiste)
            {
                return BadRequest("Pessoa não cadastrada");
            }

            return Ok(model);
        }
    }
}