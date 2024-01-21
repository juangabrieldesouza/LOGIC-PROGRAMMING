using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise27
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("----------------------");
            Console.WriteLine(" ANALISE DE APROVAÇÃO ");
            Console.WriteLine("----------------------");

            Console.Write("Digite a primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Digite a segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double media = (nota1 + nota2)/2;

            Console.WriteLine("------STATUS-------");
            Console.WriteLine("Media do aluno: "+media);
            if (media < 5)
            {
                Console.WriteLine("STATUS: Reprovado");
            } else if (media >= 5 && media < 7)
            {
                Console.WriteLine("STATUS: Recuperação");
            } else if (media >= 7) 
            {
                Console.WriteLine("STATUS: Aprovado");
            }

        }
    }
}
