using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// ExemploFundamentos é o que define o namespace do projeto, namespace é o que dá o nome para o projeto
namespace ExemploFundamentos.Models.Pessoa
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }

        // Apresentar(string @class) O @ signifca que a palavra reservada "class" pode ser usada como nome de parâmetro (Não recomendado)
        public void Apresentar()
        {
            Console.WriteLine($"Olá, meu nome é {Nome} e tenho {Idade} anos.");
        }
    }
}