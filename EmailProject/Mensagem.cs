using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProject
{
    public class Mensagem
    {
        public string conteudo { get; set; }
        public string remetente { get; set; }
        public string destinatario { get; set; }

        public Mensagem()
        {

        }

        public Mensagem(string conteudo, string remetente, string destinatario)
        {
            this.conteudo = conteudo;
            this.remetente = remetente;
            this.destinatario = destinatario;
        }

        public override string ToString()
        {
            return "Remetente : " +
                remetente +
                "\nDestinatário : " +
                destinatario +
                "\nMensagem : " +
                conteudo;
        }

    }
}
