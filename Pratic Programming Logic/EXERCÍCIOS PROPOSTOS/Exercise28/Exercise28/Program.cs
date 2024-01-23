using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("   CALCULO TERRENO");
            Console.WriteLine("-----------------------------------");
            Console.Write("Digite a largura do terreno: ");
            double largura = double.Parse(Console.ReadLine());

            Console.Write("Digite o comprimento do terreno: ");
            double comprimento = double.Parse(Console.ReadLine());


            double terreno = largura * comprimento;
            Console.WriteLine("-----------------STATUS--------------");

            if (terreno > 0) Console.WriteLine("A área do terreno é de " + terreno + "m²");

            if (terreno > 0 && terreno <= 100)
            {

                Console.WriteLine("Terreno: POPULAR");

            } else if (terreno > 100 && terreno < 500)
            {
                Console.WriteLine("Terreno: MASTER");
            } else if (terreno > 500)
            {
                Console.WriteLine("Terreno: VIP");
            }else Console.WriteLine("Valor inválido digite novamente por favor");
        }
    }
}
