using System.ComponentModel.DataAnnotations;

namespace PrimeiraApi.Model
{
    public class Funcionario
    {
        [Key]

        public int id { get; private set; }
        public string nome { get; private set; }
        public int idade { get; private set; }

        public Funcionario(string nome, int idade)
        {
            this.nome = nome ?? throw new ArgumentNullException(nameof(nome));
            this.idade = idade;
        }
    }
}
