using System;


namespace Desafio4Exer3
{
    class Program
    {
        static void Main(string[] args)
        {
            MensagemWhatsapp mensagemWhatsapp = new MensagemWhatsapp();
            Console.WriteLine("De:");
            mensagemWhatsapp.De = Console.ReadLine();
            Console.WriteLine("Escreva a mensagem:");
            mensagemWhatsapp.Texto = Console.ReadLine();
            Console.Clear();
            string Enviar = mensagemWhatsapp.Enviar();
            Console.WriteLine(Enviar);
            Console.WriteLine("-------------------------------");
            MensagemSms sms = new MensagemSms();
            Console.WriteLine("De:");
            sms.De = Console.ReadLine();
            Console.WriteLine("Escreva a mensagem:");
            sms.Texto = Console.ReadLine();
            Console.Clear();
            string Enviar2 = sms.Enviar();
            Console.WriteLine(Enviar2);
            Console.WriteLine("-------------------------------");

        }
    }
}