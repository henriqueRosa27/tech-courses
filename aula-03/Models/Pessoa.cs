using System.ComponentModel.DataAnnotations;

namespace aula_03.Models
{
    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CPF { get; set; }
    }
}