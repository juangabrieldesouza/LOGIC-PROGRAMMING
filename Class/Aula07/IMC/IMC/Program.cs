using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Massa em kg: ");

            double massa = double.Parse(Console.ReadLine());

            Console.Write("Altura em centimétros: ");


            double altura = double.Parse(Console.ReadLine());

            altura = altura / 100;

            Console.WriteLine("-----------------------------");

            double IMC = massa / (altura*altura);

            Console.WriteLine("O seu IMC é de: "+IMC.ToString("F2"));
            Console.WriteLine("-----------------------------");
            Console.Write("STATUS: ");

            if (IMC >= 18.5 && IMC < 25) 
            {
                Console.WriteLine("Peso ideal");

            }
            else { Console.WriteLine("Seu peso não está na faixa ideal!"); }

        }
    }
}
