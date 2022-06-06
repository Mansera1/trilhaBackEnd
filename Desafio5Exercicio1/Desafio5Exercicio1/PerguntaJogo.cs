using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio5Exercicio1
{
    public class PerguntaJogo
    {
        public string Pergunta { get; set; }
        public string Resposta { get; set; }


        public PerguntaJogo()
        {
            this.Pergunta = "";
            this.Resposta = "";
        }
        

        public PerguntaJogo(string pergunta, string resposta)
        {
            this.Pergunta = pergunta;
            this.Resposta = resposta;
        }

       


    }
}
