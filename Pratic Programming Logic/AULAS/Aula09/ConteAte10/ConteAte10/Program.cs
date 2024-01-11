using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConteAte10
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("você quer contar até quantos?  ");
            int valor = int.Parse(Console.ReadLine());


            Console.Write("Qual o intervalo? ");
            int pulo = int.Parse(Console.ReadLine());

            int contador = 0;

            while (contador <= valor)
            {
                Console.WriteLine(contador);

                contador = contador + pulo;
            }



            /**************************************************************
             * 
             * USO WHILE

            /*int contador = 0;

            while (contador >= 10 ) 
            {
                Console.WriteLine(contador);

                contador++;

            }*/

            /**************************************************************

            /*int contador = 10;

            while (contador > 0)
            {
                Console.WriteLine(contador);
                contador--;
            }

            Console.WriteLine("Terminei de contar");*/

            //**************************************************************




        }
    }
}
