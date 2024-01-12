using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContarDowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual tabuada você quer ver? ");
             int n = int.Parse(Console.ReadLine());
             int cont = 1;
             do
             {
                 Console.WriteLine(n +" x " +cont +" = "+(cont * n));

                 cont++;

             } while (cont <= 10);

           

        }
    }
}
