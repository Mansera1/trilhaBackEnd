using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4Exer3
{
    abstract class Mensagem
    {
        public string De { get; set; }
        public string Texto { get; set; }

        public Mensagem()
        {

        }

        public Mensagem(string de, string texto)
        {
            De = de;
            Texto = texto;
        }

        public abstract string CorpoMensagem();

        public abstract string Enviar();
        
    }
}
