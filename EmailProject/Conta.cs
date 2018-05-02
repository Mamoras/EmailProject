using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProject
{
    public class Conta : IComparable<Conta>
    {
        public string senha { get;  set; }
        public string login { get;  set; }
        public string nome { get;  set; }
        public List<Mensagem> mensagens { get; set; }


        public Conta()
        {

        }

        public Conta(string senha, string login, string nome)
        {
            this.senha = senha;
            this.login = login;
            this.nome = nome;
            mensagens = new List<Mensagem>();

        }




        public override string ToString()
        {
            return "Login: " + login +
                "\nNome: " + nome; 
        }

        public int CompareTo(Conta other)
        {
            return this.nome.CompareTo(other.nome);
        }
    }
}
