using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParOuImpar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Escreva um número: ");
            int numero = int.Parse(Console.ReadLine());
            ParEimpar(numero);


            void algo()
            {

            }
        }

        static void ParEimpar(int numero)
        {
            if (numero % 2 == 0)
            {
                Console.WriteLine("Esse número é par");
            }else Console.WriteLine("Esse número é impar");
        }
    }
}
