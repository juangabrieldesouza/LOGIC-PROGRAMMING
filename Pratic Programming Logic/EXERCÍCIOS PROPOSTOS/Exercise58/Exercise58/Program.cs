using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise58
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int alunos = 0, idade = 0, id = 0, contador = 1;


            while (idade != 999)
            {
                Console.Write("Digite a idade do "+contador+"o. aluno: ");
                idade = int.Parse(Console.ReadLine());
                if (idade != 999)
                {
                    alunos++;
                }
                contador++;
                id = id + idade; 
            }

            id = id / alunos;

            Console.WriteLine("Quantidade de alunos: "+alunos);
            Console.WriteLine("Media de idade da turma: " + id);




        }
    }
}
