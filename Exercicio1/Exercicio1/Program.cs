using System;
using System.Globalization;



namespace Exercicio1
{
    public class Program
    {
        static void Main(string[] args)
        {
            double n1, n2, n3, n4, n5, maior, menor, diferença;

            String[] valores = Console.ReadLine().Split(' ');

            n1 = double.Parse(valores[0], CultureInfo.InvariantCulture);
            n2 = double.Parse(valores[1], CultureInfo.InvariantCulture);
            n3 = double.Parse(valores[2], CultureInfo.InvariantCulture);
            n4 = double.Parse(valores[3], CultureInfo.InvariantCulture);
            n5 = double.Parse(valores[4], CultureInfo.InvariantCulture);

            if (n1 > n2 && n1 > n3 && n1 > n4 && n1 > n5)
            {
                maior = n1;
                Console.WriteLine("MAIOR = " + n1);
            }
            else if (n2 > n1 && n2 > n3 && n2 > n4 && n2 > n5)
            {
                maior = n2;
                Console.WriteLine("MAIOR = " + n2);
            }
            else if (n3 > n1 && n3 > n2 && n3 > n4 && n3 > n5)
            {
                maior = n3;
                Console.WriteLine("MAIOR = " + n3);
            }
            else if (n4 > n1 && n4 > n2 && n4 > n3 && n4 > n5)
            {
                maior = n4;
                Console.WriteLine("MAIOR = " + n4);
            }
            else
            {
                maior = n5;
                Console.WriteLine("MAIOR = " + n5);
            }
            if (n1 < n2 && n1 < n3 && n1 < n4 && n1 < n5)
            {
                menor = n1;

            }
            else if (n2 < n1 && n2 < n3 && n2 < n4 && n2 < n5)
            {
                menor = n2;

            }
            else if (n3 < n1 && n3 < n2 && n3 < n4 && n3 < n5)
            {
                menor = n3;

            }
            else if (n4 < n1 && n4 < n2 && n4 < n3 && n4 < n5)
            {
                menor = n4;

            }
            else
            {
                menor = n5;

            }

            diferença = maior - menor;
            Console.WriteLine("DIFERENÇA = " + diferença);


        }
    }
}