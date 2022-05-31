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
            pessoa.Cumprimentar();
            pessoa.DizerIdade();

            Console.WriteLine("Aluno:");
            Aluno aluno = new Aluno();
            aluno.Idade = 21;
            Console.WriteLine(aluno.Idade);
            aluno.IrParaEscola();
            aluno.DizerIdade();
            aluno.Cumprimentar();

            Console.WriteLine("Professor");
            Professor professor = new Professor();
            professor.Idade = 30;
            Console.WriteLine(professor.Idade);
            professor.Cumprimentar();
            professor.DizerIdade();
            professor.Explicar();
            

        }

    }
}