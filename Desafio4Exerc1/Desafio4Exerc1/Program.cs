using Desafio4Exerc1;
using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Entre com a primeira pessoa:");
        Pessoa pessoa = new Pessoa();
        Console.Write("Nome:");
        pessoa.Nome = Console.ReadLine();
        Console.Write("Idade:");
        pessoa.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com a segunda pessoa:");
        Pessoa pessoa2 = new Pessoa();
        Console.Write("Nome:");
        pessoa2.Nome = Console.ReadLine();
        Console.Write("Idade:");
        pessoa2.Idade = int.Parse(Console.ReadLine());

        Console.WriteLine("Entre com a terceira pessoa:");
        Pessoa pessoa3 = new Pessoa();
        Console.Write("Nome:");
        pessoa3.Nome = Console.ReadLine();
        Console.Write("Idade:");
        pessoa3.Idade = int.Parse(Console.ReadLine());
        

        if (pessoa.Idade > pessoa2.Idade && pessoa.Idade > pessoa3.Idade)
        {
            pessoa.ExibirDados();
        }
        else if(pessoa2.Idade > pessoa.Idade && pessoa2.Idade > pessoa3.Idade)
        {
            pessoa2.ExibirDados();
        }
        else
        {
            pessoa3.ExibirDados();
        }



    }
}


