using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise42
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int c = 0;
            Console.Write("Digite um valor: ");
            int valor = int.Parse(Console.ReadLine());

            while (c <= valor)
            {
                Console.Write(" "+c);
                c++;
            }
            Console.WriteLine();
        }
    }
}
