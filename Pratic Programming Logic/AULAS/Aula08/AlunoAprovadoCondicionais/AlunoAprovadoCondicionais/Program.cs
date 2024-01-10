using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlunoAprovadoCondicionais
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------");
            Console.WriteLine("ESCOLA VITÓRIA RÉGIA");
            Console.WriteLine("---------------------");

            Console.Write("Primeira Nota: ");
            float nota1 = float.Parse(Console.ReadLine());

            Console.Write("Segunda Nota: ");
            float nota2 = float.Parse(Console.ReadLine());

            float nota = (nota1 + nota2) / 2;

            Console.WriteLine("--------------------");

            Console.WriteLine("MÉDIA: " + nota.ToString("F1"));

            if (nota >= 6) Console.WriteLine("ALUNO APROVADO");

            else if (nota < 6 & nota >= 4) Console.WriteLine("ALUNO EM RECUPERAÇÃO");

            else Console.WriteLine("ALUNO REPROVADO");

            Console.WriteLine("--------------------");
            //   /  \
        }
    }
}
