using System;
using System.Collections.Generic;


namespace Desafio4Exerc1
{
     class Pessoa
    {

        public int Idade { get; set; }
        public string Nome { get; set; }
        public int Idade2 { get; set; }
        public string Nome2 { get; set; }
        public int Idade3 { get; set; }
        public string Nome3 { get; set; }


        public Pessoa()
        {
        }

        public Pessoa(int idade, string nome, int idade2, string nome2, int idade3, string nome3)
        {
            Idade = idade;
            Nome = nome;
            Idade2 = idade2;
            Nome2 = nome2;
            Idade3 = idade3;
            Nome3 = nome3;
        }

       
    }

   
}
