using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------------");
            Console.WriteLine("  ESCOLA VITÓRIA REGIA ");
            Console.WriteLine("-------------------------");

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());

            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            nota1 = (nota2+nota1)/2;
            Console.WriteLine("---------------------------");
            Console.WriteLine("Nota do Aluno: "+nota1.ToString("F2"));
            if (nota1 < 7) Console.WriteLine("O aluno NÃO teve um bom aproveitamento");
            else Console.WriteLine("O aluno teve um bom aproveitamento");
        }
    }
}
