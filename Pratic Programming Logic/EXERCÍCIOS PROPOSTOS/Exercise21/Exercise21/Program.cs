using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise21
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um ano (yyyy): ");
            int ano = int.Parse(Console.ReadLine());



            Console.WriteLine("-------------------");

            if (ano % 4 == 0 ||  ano % 400 == 0 ) Console.WriteLine("É um ano bissexto!");
            
            else Console.WriteLine("Não é um ano Bissexto!");

        }
    }
}
