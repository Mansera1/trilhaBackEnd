﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4Exerc2
{
    public class Pessoa
    {
        public Pessoa() { }

        public string Nome { get; set; }
        public int Idade { get; set; }

        public Pessoa(int idade, string nome)
        {
            this.Idade = idade;
            this.Nome = nome;
        }

        public void Cumprimentar()
        {
            Console.WriteLine("Bom dia");
        }

        public void DizerIdade()
        {
            Console.WriteLine(Idade);
        }
    }
}
