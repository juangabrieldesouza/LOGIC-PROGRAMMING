using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise56
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = 0;
            int number2 = 0;

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Programa de somátoria de números!");
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Digite '1111' para interrromper a soma!");
            do
            {

                Console.Write("Digite o numero: ");
                number2 = int.Parse(Console.ReadLine());

                if (number2 != 1111) number += number2;

            } while (number2 != 1111);
            
            Console.WriteLine("Total da soma é "+number);
        }
    }
}
