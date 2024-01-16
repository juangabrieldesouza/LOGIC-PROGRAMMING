using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumerosPrimos
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Digite um número: ");
            int numero = int.Parse(Console.ReadLine());
            int contDIV=0;
            int cont = 1;
            do
            {
                if(numero % cont == 0) contDIV = contDIV + 1;
                
                cont++;
            } while (cont <= numero);
            Console.WriteLine("\n Existem " + contDIV+ " numeros divisiveis por "+numero);
            if (contDIV == 2)
            {
                Console.WriteLine("O número é primo!");
            } else Console.WriteLine("O número não é primo!");


        }
        // \
    }
}
