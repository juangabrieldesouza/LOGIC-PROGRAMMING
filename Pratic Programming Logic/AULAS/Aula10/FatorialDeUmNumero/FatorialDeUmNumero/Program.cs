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
            int num = 1;
            
             Console.Write("Qual número você deseja fatorar? ");
             numero = int.Parse(Console.ReadLine());
             

             cont = numero;
             do 
             {

                
                numeroFat = numeroFat * cont;
                
                cont--;

                                
               
                

            } while (cont > 1);

            Console.WriteLine(" \nO fatorial de " + numero+ " é "+numeroFat );



        }
    }
}
