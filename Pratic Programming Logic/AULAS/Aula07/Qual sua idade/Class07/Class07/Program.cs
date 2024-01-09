using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Em que ano estamos? ");
            
            int ano = int.Parse(Console.ReadLine());
            
            Console.WriteLine("Em que ano você nasceu? ");
            
            int anoNasc = int.Parse(Console.ReadLine());
            int idade = ano - anoNasc;
            
            Console.Write($"em {ano} você tera " + idade + " anos");
            
            if (idade > 17) 
            {
                Console.WriteLine(" e você ja tera atingindo a maioridade");
            }
            else
            {
                Console.WriteLine(" e você ainda nao atingiu a maioridade");
            }

        }
    }
}
