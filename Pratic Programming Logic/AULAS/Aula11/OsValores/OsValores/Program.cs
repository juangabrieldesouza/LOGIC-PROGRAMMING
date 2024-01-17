using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsValores
{
    internal class Program
    {
        static void Main(string[] args)
        {


            int numero = 0;
            string resposta = "";
            int valor = 0;
            int somaImpar = 0;

            
            for (int i = 1; i <= 6; i++)
            {
                Console.Write("Digite um número: ");
                numero = int.Parse(Console.ReadLine());

                if (numero > 0 && numero < 10 )
                {
                    valor++;

                    
                }
                if (numero % 2 == 1) somaImpar = somaImpar + numero;


            }
            Console.WriteLine("Existem "+valor+ " valores entre 0 e 10!");
            Console.WriteLine("A soma dos números que são ímpares é: " + somaImpar);
        }
    }
}
