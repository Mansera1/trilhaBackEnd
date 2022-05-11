using System;
using System.Globalization;


namespace Exercicio4
{
    public class ordenacaoVetorString

    {
        static void Main(string[] args)
        {
            
            string[] nomes = Console.ReadLine().Split(' ');
            
            StringComparer ordenar = StringComparer.InvariantCultureIgnoreCase;
            Array.Sort(nomes, ordenar);
            Console.WriteLine();
            Console.WriteLine("Todos os nomes foram salvos com sucesso");
            for (int i = 0; i < nomes.Length; i++)
                Console.WriteLine(nomes[i]);
            
           
        }
    }
}
