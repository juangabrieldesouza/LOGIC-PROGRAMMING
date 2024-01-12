using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("Salário Funcinário");
            Console.WriteLine("---------------------");

            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();

            Console.Write("Digite o Salário do Funcionário: ");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine("------------------");
            double aumento = 15 * (salario / 100);
            salario = salario + aumento;
            Console.WriteLine("O funcionário " +nome+ " vai ter um novo\n salário de R$" + salario.ToString("F2"));
        }
    }
}
