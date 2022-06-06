using System;


namespace Desafio5Exercicio2
{
    public class Retangulo
    {
        public int Altura { get; set; }
        public int Largura { get; set; }

        public Retangulo()
        {

        }

        public Retangulo(int altura, int largura)
        {
            this.Altura = altura;
            this.Largura = largura; ;
        }

        public void Mostrar()
        {
            Console.WriteLine("Altura = "+ Altura + "Largura = " + Largura);
        }
    }
    

}
