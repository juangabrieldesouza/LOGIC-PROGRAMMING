using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace MelhorAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("ESCOLA FREI AMBRÓSIO");
            Console.WriteLine("--------------------");
            Console.Write("Quantos alunos a escola tem? ");
            int quantidadeAlunos = int.Parse(Console.ReadLine());
            
            string nomeAluno;
            double notaAluno = 0;
            double maior = notaAluno;
            string melhorAluno="";
            int contador = 1;
            Console.WriteLine("=============================");
            while (contador <= quantidadeAlunos) 
            { 
                Console.Write("Nome do "+contador+".o Aluno: ");
                nomeAluno = Console.ReadLine();
                Console.Write("Nota: ");
                notaAluno = int.Parse(Console.ReadLine());
                if (notaAluno > maior)
                {

                    maior = notaAluno; 
                    melhorAluno = nomeAluno;
                }
                Console.WriteLine("==========================");
                contador++;
            }
            
            Console.WriteLine("O aluno "+melhorAluno+" foi o que teve o melhor aproveitamento com "+maior);





        }
    }
}
