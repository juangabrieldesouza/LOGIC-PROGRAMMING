using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContagemInteligente
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------------");
            Console.WriteLine("    CONTADOR 2000");
            Console.WriteLine("----------------------");

            Console.Write("INICIO: ");
            int inicio = int.Parse(Console.ReadLine());
            Console.Write("FIM: ");
            int fim = int.Parse(Console.ReadLine());

            int contador = inicio;


            Console.WriteLine("====== CONTANDO =====");
            if (inicio < fim) 
            {
                while (inicio <= fim) 
                {
                    Console.Write($" ...{inicio}   ");
                    inicio++;
                }
            }
            else if (inicio > fim)
            {
                while (inicio >= fim)
                {
                    Console.Write($" ...{inicio}   ");
                    inicio--;
                }
                
            }
            Console.WriteLine("\n" + "===================");

        }
    }
}
