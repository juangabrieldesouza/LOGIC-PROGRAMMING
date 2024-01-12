using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("TINTAS & CIA");
            Console.WriteLine("------------------");


            Console.Write("Qual a altura da parede em metros? ");
            double altura = double.Parse(Console.ReadLine());

            Console.Write("Qual a largura da parade em metros? ");
            double largura = double.Parse(Console.ReadLine());

            double baseParede = altura * largura;

            double areaTinta = baseParede / 2;
            Console.WriteLine("--------------");
            Console.WriteLine("Medida total da parede: " + baseParede.ToString("F2") + "m²");
            Console.WriteLine("Quantidade de litros de tinta: "+areaTinta.ToString("F2")+"L");

        }
    }
}
