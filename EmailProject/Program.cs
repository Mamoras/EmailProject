using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProject
{
    class Program
    {
        public static List<Conta> contas;

        static void Main(string[] args)
        {

            contas = new List<Conta>();

            Conta c1 = new Conta("123", "login", "João Marcos");
            contas.Add(c1);
            Conta c2 = new Conta("321", "user", "Maria");
            contas.Add(c2);
            Conta c3 = new Conta("abc", "mario", "Mario");
            contas.Add(c3);


            int opcao = 0;
            while (opcao != 6)
            {
                Tela.mostrarTela();
                Console.Write("Escolha uma opção: ");            
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    opcao = 0;
                }
                
                
                if (opcao == 1)
                {
                    try
                    {
                        Tela.fazerLogin();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro inesperado! " + e.Message);
                        opcao = 0;
                    }
                }

                if (opcao == 2)
                {
                    try
                    {
                        Tela.fazerCadastro();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Erro ao fazer cadastro: " + e.Message);
                        opcao = 0;
                    }
                }
                
                Console.Clear();

            }
            Console.ReadLine();




        }
    }
}
