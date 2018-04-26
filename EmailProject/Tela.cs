﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProject
{
    class Tela
    {
        public static void mostrarTela()
        {
            Console.WriteLine("1 - Fazer login");
            Console.WriteLine("2 - Fazer cadastro");
            Console.WriteLine("3 - Esqueceu sua senha?");
            Console.WriteLine("4 - Esqueceu seu login?");
            Console.WriteLine("5 - Escrever Mensagem");
            Console.WriteLine("6 - Sair");
            Console.WriteLine();
            Console.Write("Selecione uma opção: ");
        }


        public static void fazerLogin()
        {

            Console.Clear();
            Console.Write("Digite seu login: ");
            string login = Console.ReadLine();
            int y = Program.contas.FindIndex(x => x.login == login);
            if (y != -1)
            {
                Console.WriteLine();
                Console.Write("Digite sua senha: ");
                string senha = Console.ReadLine();
                int x = Program.contas.FindIndex(f => f.senha == senha);
                if (x != -1)
                {
                    Console.WriteLine();
                    Console.WriteLine("Olá " + Program.contas[y].nome + "!");
                    if(Program.contas[y].mensagens.Count == 0)
                    {
                        Console.WriteLine("Você não possui mensagens!");
                        Console.ReadLine();
                        Console.Clear();
                    }
                    else
                    {
                        Console.WriteLine("Você tem " + Program.contas[y].mensagens.Count + " mensagens.");
                        Console.Write("Gostaria de ler suas mensagens? (s/n): ");
                        char opcao = char.Parse(Console.ReadLine());
                        if(opcao == 's')
                        {
                            for (int i = 0; i < Program.contas[y].mensagens.Count; i++)
                            {
                                Console.WriteLine("Mensagem numero " + (i + 1) + ":");
                                Console.WriteLine(Program.contas[y].mensagens[i]);
                                Console.ReadLine();
                                Console.Clear();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Retornando à tela inicial.");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Senha incorreta!");
                    Console.ReadLine();
                }
            }
            else
            {
                Console.WriteLine("Login não encontrado!");
                Console.ReadLine();
            }


        }

        public static void fazerCadastro()
        {
            Console.Write("Digite o login a ser cadastrado: ");
            string login = Console.ReadLine();
            int x = Program.contas.FindIndex(f => f.login == login);
            if(x == -1)
            {
                throw new ModelException("Este login já está em uso!");
            }
            

        }




    }
}
