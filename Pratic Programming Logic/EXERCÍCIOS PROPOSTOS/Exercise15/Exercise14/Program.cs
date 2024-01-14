using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            
            Console.WriteLine("--------------------------");
            Console.WriteLine("     CALCULO SALÁRIO");
            Console.WriteLine("--------------------------");


            Console.Write("Quantos dias o funcionário trabalhou? ");
            int salario = int.Parse(Console.ReadLine());

            salario = salario * 8 * 25;


            Console.WriteLine("=================");

            Console.WriteLine("Salário: R$"+salario);



        }
    }
}
