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

         public void Explicar()
        {
            Console.WriteLine("O Naruto pode ser um pouco duro às vezes, talvez você não saiba disso, mas o Naruto também cresceu sem pai. Na verdade ele nunca conheceu nenhum de seus pais, e nunca teve nenhum amigo em nossa aldeia.");
                
        }

        public void DizerIdade()
        {
            Console.WriteLine(Idade);
        }
    }
}
