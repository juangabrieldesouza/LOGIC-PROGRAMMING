using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("TERÇA PARTE E DOBRO");
            Console.WriteLine("-------------------");
            Console.Write("Digite um número: ");
            float num1 = float.Parse(Console.ReadLine());
            Console.WriteLine("O dobro de " + num1 + " é "+(num1 * 2));
            Console.WriteLine("A terça parte de "+num1+" é "+(num1/3));


        }
    }
}
