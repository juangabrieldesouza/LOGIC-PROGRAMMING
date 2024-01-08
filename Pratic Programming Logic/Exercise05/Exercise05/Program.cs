using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite um número: ");
            double num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("O sucessor de "+num1+" é "+ (num1 +1)+"\n");
            Console.WriteLine("E o antecessor de " + num1 + " é " + (num1-1));
        }
    }
}
