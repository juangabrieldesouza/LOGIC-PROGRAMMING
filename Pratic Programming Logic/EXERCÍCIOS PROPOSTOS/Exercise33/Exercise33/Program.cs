using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o valor da casa: R$");
            double casa = double.Parse(Console.ReadLine());


            Console.Write("Digite o seu salário: R$");
            double salario = double.Parse(Console.ReadLine());


            double margem = salario - (salario * (70.0 / 100.0));

            Console.Write("Em quantos anos você quer pagar? ");
            int ano = int.Parse(Console.ReadLine());

            double emprestimo = casa / ((ano * 365)/12);
            
            if (emprestimo > margem) 
            {
                Console.WriteLine("NÃO APROVADO");
            } else if (emprestimo <= margem) 
            {
                Console.WriteLine("Valor da parcela: R$"+emprestimo.ToString("F2"));
                Console.WriteLine("Valor do EMPRÉSTIMO: R$"+casa);
            }

        }
    }
}
