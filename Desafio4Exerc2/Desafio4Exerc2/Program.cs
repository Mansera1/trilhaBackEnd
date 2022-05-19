using System;
using System.Runtime.CompilerServices;

namespace Desafio4Exerc2
{
    class Program
    {
        static void Main(string[] args)
        {
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Nome:");
            pessoa.Nome = Console.ReadLine();
            Console.WriteLine("Idade:");
            pessoa.Idade = int.Parse(Console.ReadLine());

            string Cumprimentar = pessoa.Cumprimentar();
            Console.WriteLine(Cumprimentar);
            Console.WriteLine("Minha idade é " + pessoa.Idade);

            Console.WriteLine("Aluno:");
            Aluno aluno = new Aluno();
            aluno.Idade = 21;
            Console.WriteLine(aluno.Idade);

            string IrPraEscola = aluno.IrParaEscola();
            Console.WriteLine(IrPraEscola);
            string Cumprimentar2 = aluno.Cumprimentar();
            Console.WriteLine(Cumprimentar2);
            Console.WriteLine("Minha idade é " + aluno.Idade);

            Console.WriteLine("Professor");
            Professor professor = new Professor();
            professor.Idade = 30;
            Console.WriteLine(professor.Idade);
            string Cumprimentar3 = professor.Cumprimentar();
            Console.WriteLine("Minha idade é " + professor.Idade);
            string Explicar = professor.Explicar();
            Console.WriteLine(Explicar);

        }

    }
}