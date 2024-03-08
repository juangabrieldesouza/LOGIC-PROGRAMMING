using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise63
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double valor = 0, valorTotal = 0, menorValor = double.MaxValue, pares = 0;
            string resposta = "S";
            int contador = 0;
            do
            {
                contador++;
                if (contador == 1) Console.Write("Digite um número: ");

                else Console.Write("Digite outro número: ");
                valor = int.Parse(Console.ReadLine());
                Console.WriteLine("------------");
                

                valorTotal = valorTotal + valor;

                if (valor < menorValor) menorValor = valor;

                if (valor % 2 == 0) pares++;

                Console.Write("Quer continuar? (s/n) ");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();
                Console.WriteLine("------------------------");
            } while (resposta == "S");

            if (menorValor == double.MaxValue) menorValor = 0;

            Console.WriteLine("Valor total entre os números é: "+valorTotal);
            Console.WriteLine("Menor valor digitado é: "+menorValor);
            Console.WriteLine("A média dos valores é: "+(valorTotal/contador));
            Console.WriteLine("Quantidade de números pares: "+pares);

        }
    }
}
