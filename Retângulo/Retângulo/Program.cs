using Retângulo;
using System;
using System.Globalization;

namespace Retângulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Retangulo novoRetangulo;

            novoRetangulo = new Retangulo();

            Console.WriteLine("Atribua os valores ");
            novoRetangulo.Lado1 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            novoRetangulo.Lado2 = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaRetangulo = novoRetangulo.CalcularArea();
            double perimetroRetangulo = novoRetangulo.CalcularPerimetro();

            Console.WriteLine(areaRetangulo);
            Console.WriteLine(perimetroRetangulo);
        }
    }
}