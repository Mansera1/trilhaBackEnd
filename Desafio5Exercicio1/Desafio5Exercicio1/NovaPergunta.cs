using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio5Exercicio1
{
    public class NovaPergunta:PerguntaJogo
    {
        public string Dica { get; set; }

        public NovaPergunta():base()
        {
            this.Dica ="";
        }

        public NovaPergunta(string pergunta, string resposta ,string dica):base(pergunta,resposta)
        {
            this.Dica = dica;
        }
    }


    
}
