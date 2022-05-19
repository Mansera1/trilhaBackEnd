using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4Exerc2
{
    class Aluno : Pessoa
    {
        public Aluno() { }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Aluno(string nome, int idade)
        {
            Nome = nome;
            Idade = idade;
        }

         public string IrParaEscola()
        {
            return "Cheguei na escola";
        }
    }

   
}
