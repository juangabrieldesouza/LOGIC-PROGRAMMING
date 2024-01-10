using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DependentesFuncionarioSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(" Qual o nome do funcionário? ");
            string nome = Console.ReadLine();

            Console.Write(" Qual é o salario do funcionário? R$");
            double salario = double.Parse(Console.ReadLine());

            Console.WriteLine(" Qual é a quantidade de dependentes do funcionário? ");
            int dependentes = int.Parse(Console.ReadLine());

            switch (dependentes)
            {
                case 0: salario = salario + (5 * (salario/100)); 
                    break;
                case 1:
                case 2:
                case 3:
                    salario = salario + (10 * (salario / 100));
                    break;
                case 4:
                case 5:
                case 6:
                    salario = salario + (15 * (salario / 100));
                    break;
                default:
                    salario = salario + (18 * (salario / 100));
                    break;

                
            }
            Console.WriteLine("----------------");
            Console.WriteLine("NOME DO FUNCIONÁRIO: "+nome);
            Console.WriteLine("SALÁRIO: R$"+salario.ToString("F2"));
            Console.WriteLine("----------------");
        }
    }
}
