using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o lado A: ");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado B: ");
            double b  = double.Parse(Console.ReadLine());

            Console.Write("Digite o lado C: ");
            double c = double.Parse(Console.ReadLine());



            if (a + b > c && b + c > a && c + a > b)
            {
                Console.WriteLine("É um triângulo");
                if ((a == b && a != c) || (b == c && b != a) || (a == c && a != b) )
                {
                    Console.WriteLine("ISÓSCELES: Dois lados iguais!");    
                } else if (a ==b && b == c) 
                {
                    Console.WriteLine("EQUILÁTERO: Todos lados são iguais!");
                } else if (a != c && b != a && c != b) 
                {
                    Console.WriteLine("ESCALENO: todos os lados diferentes!"); 
                }

            } else Console.WriteLine("Não é um triângulo");

        }
    }
}
