using System;

namespace Exercicio3;

class Program
{
    static void Main(string[] args)
    {
        int codigo;
        codigo = int.Parse(Console.ReadLine());
        
        if(codigo == 3251)
        {
            Console.WriteLine("Código certo");
        }
        else
        {
            Console.WriteLine("Código incorreto");
        }
        
        while (codigo != 3251)
        {
            if (codigo < 3251)
            {
                Console.WriteLine("Código correto é maior");
            }
            else
            {
                Console.WriteLine("Código correto é menor");
            }
            codigo = int.Parse(Console.ReadLine());
        }
        

    }
}
