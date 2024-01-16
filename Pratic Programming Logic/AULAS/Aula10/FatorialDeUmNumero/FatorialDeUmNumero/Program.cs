using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FatorialDeUmNumero
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numeroFat = 1;
            int cont = 1;
            int numero= 1;
            string resposta = "";
            
             

            
             
            do
            {
                Console.Write("Qual número você deseja fatorar? ");
                numero = int.Parse(Console.ReadLine());
                cont = numero;
                do
                {


                    numeroFat = numeroFat * cont;

                    cont--;


                    


                } while (cont > 1);
                Console.WriteLine(" O fatorial de " + numero + " é " + numeroFat);
                Console.WriteLine("Quer continuar? (S/N) ");
                resposta = Console.ReadLine();
                cont = 0;
                numeroFat = 1;
            } while (resposta == "S");

        }
    }
}
