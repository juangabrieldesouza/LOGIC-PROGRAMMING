using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("VALOR DE DELTA");
            Console.WriteLine("----------------");

            Console.Write("Digite o valor de A: ");
            int valordeA = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de B: ");
            int valordeB = int.Parse(Console.ReadLine());
            Console.Write("Digite o valor de C: ");
            int valordeC = int.Parse(Console.ReadLine());

            double delta = Math.Pow(valordeB, 2) - 4 * valordeA * valordeC;
            Console.WriteLine("-------------------");
            Console.WriteLine("Valor de Delta: "+delta);


        }
    }
}
