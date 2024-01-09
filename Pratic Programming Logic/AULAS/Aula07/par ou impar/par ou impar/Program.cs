using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace par_ou_impar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------");
            Console.WriteLine("PAR OU IMPAR");
            Console.WriteLine("--------------");

            Console.Write("Digite um numero qualquer: ");
            int n = int.Parse(Console.ReadLine());

            n = 2 % n;

            if (n == 0) 
            {

                Console.WriteLine("O numero e' par!");

            } else Console.WriteLine("O numero e' impar");
        }
    }
}
