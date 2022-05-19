using Desafio4Exerc1;
using System;
using System.Collections.Generic;
using System.Text;


class Program
{
    static void Main(string[] args)
    {
        List<Pessoa> pessoas = new List<Pessoa>();

        Console.WriteLine("Entre com a quantidade de pessoas: ");
        int numero = int.Parse(Console.ReadLine());

        for (int i = 1; i < numero; i++)
        {
            Console.WriteLine($"Dados da #{i} pessoa:");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            int idade = int.Parse(Console.ReadLine());



        }

        foreach (Pessoa p in pessoas)
        {
            Console.WriteLine(p.Nome + " " + p.Idade);
        }
        Console.ReadKey();


    }
}


