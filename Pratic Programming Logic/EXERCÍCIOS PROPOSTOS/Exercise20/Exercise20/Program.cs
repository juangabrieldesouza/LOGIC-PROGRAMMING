using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise20
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------------");
            Console.WriteLine(" NUMERO PAR OU IMPAR");
            Console.WriteLine("--------------------------");

            Console.Write("Digite um número: ");
            double n = double.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {

                Console.WriteLine("Esse número é par");
            }else Console.WriteLine("Esse número é ímpar");

        }
    }
}
