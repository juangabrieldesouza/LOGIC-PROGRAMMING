using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("    Urna Caseira");
            Console.WriteLine("---------------------");

            Console.Write("Digite a sua idade: ");
            sbyte idade = sbyte.Parse(Console.ReadLine());

            if (idade < 16)
            {
                Console.WriteLine("Você não pode votar!");
            }else Console.WriteLine("Você pode votar!");

        }
    }
}
