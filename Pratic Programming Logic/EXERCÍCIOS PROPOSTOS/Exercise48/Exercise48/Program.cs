using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise48
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 1;
            int soma = 0;
            int junto = 0;
            while (contador <= 7)
            {
                Console.Write("Digite o " + contador + "o. número: ");
                soma = int.Parse(Console.ReadLine());

                contador++;
                

                junto += soma;

            }

            Console.WriteLine("------------------------------");
            Console.WriteLine("A soma total dos números é "+junto);
        }
    }
}
