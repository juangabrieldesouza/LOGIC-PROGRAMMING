using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConteNegativos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 1;
            int numeroN = 0;

            Console.WriteLine("------------------");
            Console.WriteLine("CONTA NEGATIVOS");
            Console.WriteLine("------------------");

            do
            {
                Console.Write("Digite " + n + "o. número: ");
                int numero = int.Parse(Console.ReadLine());

                if (numero < 0) numeroN++;


                n++;

            } while (n <= 5);

            Console.WriteLine("Existem " + numeroN + " números negativos");
        }
    }
}
