using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4Exerc2
{
    class Professor : Pessoa
    {
        public Professor() { }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Professor(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

         public string Explicar()
        {
            return "A meiose é um tipo de divisão celular reducional, " +
                "pois gera células-filhas com metade do número de cromossomos. " +
                "A meiose é um processo de divisão celular caracterizado pela formação de quatro células-filhas com a metade do número de cromossomos da célula-mãe";
                
        }
    }
}
