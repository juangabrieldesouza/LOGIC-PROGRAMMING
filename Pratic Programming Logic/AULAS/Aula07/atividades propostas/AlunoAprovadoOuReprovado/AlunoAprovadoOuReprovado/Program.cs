using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoAprovadoOuReprovado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("ESCOLA VITÓRIA RÉGIA");
            Console.WriteLine("---------------------");

            Console.Write("Primeira Nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            Console.Write("Segunda Nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double nota = (nota1 + nota2)/2;

            Console.WriteLine("--------------------");
            Console.WriteLine("MÉDIA: " + nota);
            
            if (nota > 6) Console.WriteLine("ALUNO APROVADO");
            else Console.WriteLine("ALUNO REPROVADO");


            Console.WriteLine("--------------------");
            //   /  \
        }

    }
}
