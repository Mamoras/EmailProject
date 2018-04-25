using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProject
{
    class Mensagem
    {
        public string conteudo { get; set; }
        public Conta remetente { get; set; }
        public Conta destinatario { get; set; }

        public Mensagem(string conteudo, Conta remetente, Conta destinatario)
        {
            this.conteudo = conteudo;
            this.remetente = remetente;
            this.destinatario = destinatario;
        }

        public override string ToString()
        {
            return "Remetente : " +
                remetente.nome +
                "\nDestinatário : " +
                destinatario.nome +
                "\nMensagem : " +
                conteudo;
        }

    }
}
