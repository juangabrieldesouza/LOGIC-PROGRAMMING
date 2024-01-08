using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Conversor de moedas");
            Console.WriteLine("-------------------");

            Console.Write("Digite quantos reais você têm: ");
            double real = double.Parse(Console.ReadLine());
            double dolar = real / 4.8;

            Console.WriteLine("A quantidade de dólares que você pode comprar é: US$ "+dolar.ToString("F2"));




        }
    }
}
