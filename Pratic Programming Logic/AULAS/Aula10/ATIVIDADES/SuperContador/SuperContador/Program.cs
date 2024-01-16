using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace SuperContador
{
    internal class Program
    {
        static void Main(string[] args)
        {

            
            int cont;
            int numero = 0;

            do {
                Console.WriteLine("=================");
                Console.WriteLine("|      MENU     |");
                Console.WriteLine("=================");
                Console.WriteLine("| [1] De 1 a 10 |");
                Console.WriteLine("| [2] De 10 a 1 |");
                Console.WriteLine("| [3] Sair      |");
                Console.WriteLine("=================");
                Console.Write("ESCOLHA UMA OPÇÃO: ");
                numero = int.Parse(Console.ReadLine());
                if (numero == 1)
                {
                    cont = 1;
                    do
                    {


                        Console.Write(" "+cont);
                        cont++;
                    } while (cont <= 10);
                    Console.WriteLine(" ");

                } else if (numero == 2)
                {
                    cont = 10;
                    do
                    {


                        Console.Write(" "+cont);
                        cont--;
                    } while (cont >= 1);
                    Console.WriteLine("");
                }
            }   while (numero != 3);

            Console.WriteLine("FIM DO PROGRAMA");
            

        }
    }
}
