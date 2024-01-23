using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Exercise29
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double anos = 0;
            double nsala = 0;
            double salario = 0;


            Console.Write("Digite o nome do funcionário: ");
            string nome = Console.ReadLine();
            Console.Write("Digite quantos anos de trabalho do funcionário: ");
            anos = double.Parse(Console.ReadLine());
            Console.Write("Digite o sálario do funcionário: ");
            salario = double.Parse(Console.ReadLine());
                          
                    

            if(anos > 0 && anos <= 3)
            {
                nsala = salario + (salario * (3.0 / 100.0));
                Console.WriteLine("O novo Salário de "+nome+"é de "+nsala);
            } else if (anos > 3 && anos < 10) 
            {
                nsala = salario + (salario * (12.5 / 100.0));
                Console.WriteLine("O novo Salário de " +nome+ "é de " + nsala);
            } else if (anos >= 10)
            {
                nsala = salario + (salario * (12.5 / 100.0));
                Console.WriteLine("O novo Salário de " +nome+ " é de " + nsala);
            } else Console.WriteLine("Valores inválidos");

            /*-Até 3 anos de empresa: aumento de 3 %
            -entre 3 e 10 anos: aumento de 12.5 %
             -10 anos ou mais: aumento de 20 %*/

        }
    }
}
