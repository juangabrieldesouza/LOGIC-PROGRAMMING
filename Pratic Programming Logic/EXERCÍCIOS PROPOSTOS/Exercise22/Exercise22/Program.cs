using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine("Departamento de Alistamento");
            Console.WriteLine("----------------------------");

            Console.Write("Digite seu ano de nascimento: ");
            int nasc = int.Parse(Console.ReadLine());

            Console.WriteLine("-------------STATUS-------------");

            if (2024 - nasc > 18)
            {
                Console.WriteLine("Você pode se alistar!"); Console.WriteLine("Já se passaram " + ((2024 - nasc) - 18) + " anos para o seu alistamento!");
            } else if (nasc == 18){ 
                Console.WriteLine("Você pode se alistar esse ano!"); 
                
            } else if (2024 - nasc < 18) Console.WriteLine("Você ainda não pode se alistar!"); Console.WriteLine("Faltam " + (18 -(2024 - nasc)) + " anos para o seu alistamento!");
        }
    }
}
