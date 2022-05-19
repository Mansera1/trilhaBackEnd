using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Desafio4Exer3
{
    internal class MensagemSms : Mensagem
    {
        public override string CorpoMensagem()
        {
            return Texto;
        }

        public override string Enviar()
        {
            return Texto;
        }
    }
}
