using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise55
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int contador = 0;
            int numer = 0;
            Random numero = new Random();
            
            int outro = numero.Next(1,10);

            Console.WriteLine("Você tem 4 tentativas para adivinhar o número de 1 a 10");
            while (contador <= 4)
            {
                contador++;
                Console.Write("Adivinhe o número de 1 a 10: ");
                numer = int.Parse(Console.ReadLine());

                
                if (numer == outro)
                {
                    Console.WriteLine("Parabéns, valor correto!"); contador += 4;
                }
                else if (numer != outro && contador <= 4)
                {
                  Console.WriteLine("Errou, tente novamente!");


                } else Console.WriteLine(" Você perdeu ;(");


            }

            
        }
    }
}
