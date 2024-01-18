using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnalizadorDeValores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int valor = 0;
            int soma = 0;
            
            double media = 0;
            int nulo = 0;
            int div5 = 0;
            int pares = 0;
            for (int i = 1; i <= 5; i++) 
            {

                Console.Write("Digite o "+i+"o. valor: ");
                valor = int.Parse(Console.ReadLine());

                soma = soma + valor;
                media = soma / 5.0;
                if (valor == 0) { nulo++; }

                if (valor % 5 == 0) { div5++; }

                if (valor % 2 == 0) { pares = pares + valor; }
            }



            Console.WriteLine("Soma total dos valores: "+soma);
            Console.WriteLine("Média dos valores: "+media);
            Console.WriteLine("Valores divisiveis por 5: "+div5);
            Console.WriteLine("Quantidade de valores nulos: "+nulo);
            Console.WriteLine("Soma dos valores pares: "+pares);

        }
    }
}
