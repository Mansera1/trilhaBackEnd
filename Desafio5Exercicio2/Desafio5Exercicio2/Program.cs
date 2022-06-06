using System;
using System.Collections.Generic;

namespace Desafio5Exercicio2
{
    class Program
    {
        public static void Main(string[] args)
        {
            
            Retangulo retangulo1;

            retangulo1 = new Retangulo();

            Console.WriteLine("Atribua os valores ");
            retangulo1.Altura = int.Parse(Console.ReadLine());
            retangulo1.Largura = int.Parse(Console.ReadLine());
            retangulo1.Mostrar();

           



        }
    }
}
