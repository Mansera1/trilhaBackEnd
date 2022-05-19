using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4Exerc1
{
    internal class ExibirDados
    {
        public int Idade { get; set; }
        public string Nome { get; set; }

        public ExibirDados()
        {
        }

        public ExibirDados(int idade, string nome)
        {
            this.Idade = idade;
            this.Nome = nome;
        }
    }
}
