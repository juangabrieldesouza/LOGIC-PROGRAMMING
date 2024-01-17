using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite a: ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Digite b: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Digite c: ");
            double c = double.Parse(Console.ReadLine());

            if (a + b > c && c + b > a && a + c > b) 
                {
                Console.WriteLine("Se pode formar um triângulo!");
            } else Console.WriteLine("Não se pode formar um triângulo!");
        }
    }
}
