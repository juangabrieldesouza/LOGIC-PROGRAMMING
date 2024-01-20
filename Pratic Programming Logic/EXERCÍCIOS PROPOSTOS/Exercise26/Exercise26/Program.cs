using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise26
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Insira o primeiro valor: ");
            int valor1 = int.Parse(Console.ReadLine());

            Console.Write("Insira o segundo valor: ");
            int valor2 = int.Parse(Console.ReadLine());

            if (valor1 > valor2)
            {
                Console.WriteLine("O primeiro valor é maior!");
            } else if (valor1 < valor2)
            {
                Console.WriteLine("O segundo valor é maior!");
            } else if ( valor1 == valor2)
            {
                Console.WriteLine("Não tem valor maior os dois são iguais!");
            }

            

            

            
        }
    }
}
