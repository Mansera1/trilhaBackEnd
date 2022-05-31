using System;
using System.Collections.Generic;


namespace Desafio4Exerc1
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

        public void ExibirDados()
        {
            Console.WriteLine("A pessoa mais velha é " + Nome + "," + Idade +" anos");

            
            
        }





    }

    


}
