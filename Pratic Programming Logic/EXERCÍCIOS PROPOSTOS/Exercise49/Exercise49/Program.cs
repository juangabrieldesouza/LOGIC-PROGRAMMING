using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise49
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int numero = 0;
            int par = 0;
            int impar = 0;

            while(contador <= 6)
            {
                Console.Write("Digite o "+contador+"o. número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero % 2 == 0) par +=1;
                
                if (numero % 2 == 1) impar +=1;



                contador++;
            }

            Console.WriteLine("-------------------------");
            Console.WriteLine("Quantidade de números pares: "+par);
            Console.WriteLine("Quantidade de números impares: "+impar);

        }
    }
}
