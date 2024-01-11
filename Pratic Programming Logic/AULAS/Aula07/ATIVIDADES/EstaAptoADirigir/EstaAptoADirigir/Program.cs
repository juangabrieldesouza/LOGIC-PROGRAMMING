using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EstaAptoADirigir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------"); 
            Console.WriteLine("DEPARTAMENTO DE TRANSITO");
            Console.WriteLine("-------------------------\n");

            Console.Write("Ano atual (yyyy): ");
            int anoAtual = int.Parse(Console.ReadLine());
            Console.Write("Ano de nascimento (yyyy): ");
            int anoNasc = int.Parse(Console.ReadLine());
            Console.WriteLine();
            int idade = anoAtual - anoNasc;

            Console.WriteLine("------------STATUS-----------");
            Console.WriteLine("IDADE: " + idade + " anos");
            if (idade > 17)
            {
                
                Console.WriteLine("ESTÁ APTO A TIRAR A CARTEIRA");
            }else Console.WriteLine("NÃO ESTÁ APTO PARA TIRAR A CARTEIRA");

            Console.WriteLine("-----------------------------");

            // /  \

        }
    }
}
