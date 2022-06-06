using Desafio5Exercicio1;
using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<NovaPergunta> perguntas;
        perguntas = PerguntasAleatorias();
        Random r = new Random();
        int pos = r.Next(0,perguntas.Count);
        NovaPergunta pergunta = perguntas[pos];
        int tentativa = 0;
        bool pergunta1 = false;
        string resposta = "";
        while (tentativa < 3 && pergunta1 == false)
        {
            Console.WriteLine("Pergunta:" +pergunta.Pergunta);
            Console.Write("Resposta:");
            resposta = Console.ReadLine();
            if(resposta == pergunta.Resposta)
            {
                pergunta1 = true;

            }
            else
            {
                Console.WriteLine("Dica:" + pergunta.Dica);
            }
            tentativa++;
        }
        if(pergunta1 == true)
        {
            Console.WriteLine("Parabéns");
        }
        else
        {
            Console.WriteLine("Você perdeu");
        }
    }

    static List<NovaPergunta> PerguntasAleatorias()
    {
        List<NovaPergunta> lista = new List<NovaPergunta>();
        NovaPergunta pergunta = new NovaPergunta("Qual o país do mundo com a maior extensão territorial?","Russia","Fica na Europa");
        lista.Add(pergunta);
        pergunta = new NovaPergunta("Qual o tipo de relevo predominante no Brasíl?", "Planalto","Picos,serras,colinas,morros e chapadas");
        lista.Add(pergunta);
        pergunta = new NovaPergunta("Qual a capital dos Estados Unidos ?","Whasington","Casa Branca");
        lista.Add(pergunta);
        pergunta = new NovaPergunta("Em que continete fica o Brasil", "América do Sul", "Subcontinete do continente americano");
        lista.Add(pergunta);
        return lista;
    }
}