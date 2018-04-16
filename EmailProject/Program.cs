using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailProject
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcao = 0;
            while (opcao != 5)
            {
                Tela.mostrarTela();
                try
                {
                    opcao = int.Parse(Console.ReadLine());
                }
                catch (ModelException e)
                {
                    Console.WriteLine(e.Message);
                    opcao = 0;
                }


            }





            Console.ReadLine();
        }
    }
}
