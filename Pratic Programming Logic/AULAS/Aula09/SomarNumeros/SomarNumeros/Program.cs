using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace SomarNumeros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int contador = 1;
            int soma = 0;
            int numeros;
            int maior = 0;
            int menor = int.MaxValue;
            while (contador <= 3) 
            {
                Console.Write($"Escreva o {contador}.o valor: ");
                
                numeros = int.Parse( Console.ReadLine() );
                
                if ( numeros > maior) maior = numeros;

                if ( numeros < menor) menor = numeros;

                soma = soma + numeros;
                contador++;
            }

            Console.WriteLine("A soma de todos os números é "+soma);
            Console.WriteLine("O maior número é "+maior);
            Console.WriteLine("E o menor número é: "+menor);
        }
    }
}
