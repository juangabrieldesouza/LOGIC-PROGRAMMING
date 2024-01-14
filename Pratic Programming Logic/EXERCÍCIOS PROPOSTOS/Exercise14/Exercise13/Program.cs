using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Exercise13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------");
            Console.WriteLine("   Klate car");
            Console.WriteLine("----------------");

            Console.Write("Quantos dias o carro foi usado? ");
            int diasDeUso = int.Parse(Console.ReadLine());
            Console.Write("Quantos kilometros rodados? ");
            double kilometros = double.Parse(Console.ReadLine());

            diasDeUso = diasDeUso * 90;
            kilometros = kilometros * 0.2;
            double preco = diasDeUso + kilometros;

            Console.WriteLine("--------------");

            Console.WriteLine("TOTAL A SER COBRADO: R$"+preco);

        }
    }
}
