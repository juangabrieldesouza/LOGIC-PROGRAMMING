using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise46
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 6;
            int numero = 0;
            while (contador <= 100)
            {
                Console.WriteLine(contador);
                contador +=2;
                numero = numero + contador;
            }

            Console.WriteLine("SOMA TOTAL: "+numero);





        }
    }
}
