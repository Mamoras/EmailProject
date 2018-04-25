using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProject
{
    class Conta
    {
        public string senha { get; private set; }
        public string login { get; private set; }
        public string nome { get; private set; }
        public List<Mensagem> mensagens { get; set; }


        public Conta (string senha, string login, string nome)
        {
            this.senha = senha;
            this.login = login;
            this.nome = nome;
            mensagens = new List<Mensagem>();

        }





    }
}
