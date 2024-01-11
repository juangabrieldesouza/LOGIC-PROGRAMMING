using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversorWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Quantas conversões deseja realizar? ");
            int conversoes = int.Parse(Console.ReadLine());

            int contador = 1;

            while ( contador <= conversoes ) 
            {
                Console.Write(contador+"o. conversao: R$");
                double valorReal = double.Parse(Console.ReadLine());

                double valorDollar = valorReal / 4.90;


                Console.WriteLine("Valor convertido: U$"+valorDollar.ToString("F2"));
                contador++;
            }

        }
    }
}
