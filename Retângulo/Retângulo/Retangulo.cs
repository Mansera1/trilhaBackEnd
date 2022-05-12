using System;


namespace Retângulo
{
    internal class Retangulo
    {
        public double Lado1;
        public double Lado2;

        public double CalcularArea()
        {
            double area = Lado1 * Lado2;
            return area;
        }

        public double CalcularPerimetro()
        {
            double perimetro = 2 * Lado1 + (2 * Lado2);
            return perimetro;

        }
    }
}
