using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise47
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 500;
            int soma = 0;
            while (contador > 0)
            {
                Console.Write(" "+contador);
                soma = soma + contador;
                contador -=50;


            }
            Console.WriteLine(" "+soma);
        }
    }
}
