using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AproveitamentoDoAluno
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--------------------");
            Console.WriteLine("PROFICIÊNCIA ESCOLAR");
            Console.WriteLine("--------------------");


            Console.Write("Primeira nota: ");
            double nota1 = double.Parse(Console.ReadLine());
            
            Console.Write("Segunda nota: ");
            double nota2 = double.Parse(Console.ReadLine());

            double notaMedia = (nota1 + nota2)/2;

            Console.WriteLine("------STATUS------");
            if (notaMedia < 0) Console.WriteLine("ERRO!");
            else if (notaMedia > 10) Console.WriteLine("ERRO!");
            else Console.WriteLine("Media: " + notaMedia);

             

            if (notaMedia < 5 && notaMedia == 0) Console.WriteLine("PROFICIÊNCIA: F");
            
            else if (notaMedia >= 5 && notaMedia <6 ) Console.WriteLine("PROFICIÊNCIA: E");
            
            else if (notaMedia >= 6 && notaMedia < 7) Console.WriteLine("PROFICIÊNCIA: D");

            else if (notaMedia >= 7 && notaMedia < 8 ) Console.WriteLine("PROFICIÊNCIA: C");

            else if (notaMedia >= 8 && notaMedia < 9) Console.WriteLine("PROFICIÊNCIA: B");

            else if (notaMedia >= 9 && notaMedia <= 10) Console.WriteLine("PROFICIÊNCIA: A");

            else Console.WriteLine("INFORMAÇÃO INSERIDA INCORRETAMENTE");
            Console.WriteLine("------------------");
        }
    }
}
