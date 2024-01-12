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
            int numeroFat = 0;
            int cont = 1;
            int numero= 1;
            int cont2 = 1;

            Console.Write("Qual número você deseja fatorar? ");
            numeroFat = int.Parse(Console.ReadLine());
            Console.Write(numeroFat + ":  ");
            do 
            {
                Console.Write("  ... "+numeroFat+" x "+cont2+" = "+numeroFat+" ");

                if (numeroFat > cont) numero = numeroFat;
                
                numeroFat = numeroFat * cont2;

                cont = numeroFat;
                cont2 = cont;

                cont++;


            } while (cont >= numero);

        }
    }
}
