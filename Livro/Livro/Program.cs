using System;
using Livro;


namespace Livro
{
    class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();

            Console.WriteLine("Livro");
            Console.WriteLine("Nome: ");
            livro.Nome = Console.ReadLine();
            Console.WriteLine("Autor: ");
            livro.Autor = Console.ReadLine();
            Console.WriteLine("Genêro: ");
            livro.Genero = Console.ReadLine();
            Console.WriteLine("Quantidades de paginas: ");
            livro.QtdPaginas = int.Parse(Console.ReadLine());
            Console.WriteLine("Paginas lidas: ");
            livro.PaginasLidas = int.Parse(Console.ReadLine());
            int progresso = livro.VerificarProgresso();
            Console.WriteLine(progresso + " % ");
            Console.WriteLine("Paginas lidas: ");
            livro.PaginasLidas = int.Parse(Console.ReadLine());
            int progresso2 = livro.VerificarProgresso();
            Console.WriteLine(progresso2 + " % ");
            Console.WriteLine("Paginas lidas: ");
            livro.PaginasLidas = int.Parse(Console.ReadLine());
            int progresso3 = livro.VerificarProgresso();
            Console.WriteLine(progresso3 + " % ");









        }

    }
}