using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPares
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());

            if (numero % 2 == 1) numero -= 1;

            for (int i = numero; i > 0; i-=2)
            {
                Console.Write(" "+ i+ "");
                
            }
            Console.WriteLine(" \n");



        }
    }
}
