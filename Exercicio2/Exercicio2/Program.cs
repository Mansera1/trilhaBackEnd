using System;
using System.Globalization;

namespace Exercicio2
{
    public static class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, delta, x1, x2, diferenca;

            String[] valores = Console.ReadLine().Split(' ');

            a = double.Parse(valores[0], CultureInfo.InvariantCulture);
            b = double.Parse(valores[1], CultureInfo.InvariantCulture);
            c = double.Parse(valores[2], CultureInfo.InvariantCulture);

            delta = Math.Pow(b, 2.0) - 4 * a * c;

            x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);
            x2 = (-b - Math.Sqrt(delta)) / (2.0 * a);
            diferenca = x1 - x2;

            Console.WriteLine("DIFERENÇA = " + diferenca);




        }
    }
}

