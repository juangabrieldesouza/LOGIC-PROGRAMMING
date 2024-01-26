using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise37
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Digite anos trabalhados na empresa: ");
            int anos = int.Parse(Console.ReadLine());
            Console.Write("Digite o Salário atual: R$");
            double salary = double.Parse(Console.ReadLine());
            Console.Write("Digite o genêro do funcionário (M/F): ");
            string genero = Console.ReadLine();

            

            if (genero == "M")
            {

                if (anos < 20)
                {
                    salary = salary + (salary * (3.0 / 100.0));
                    Console.WriteLine("Novo Salário: " + salary);
                }//
                else if (anos >= 20 && anos <= 30)
                {
                    salary = salary + (salary * (13.0 / 100.0));
                    Console.WriteLine("Novo Salário: " + salary);
                }//
                else if (anos > 30)
                {
                    salary = salary + (salary * (25.0 / 100.0));
                    Console.WriteLine("Novo Salário: " + salary);
                }


            } else if (genero == "F") 
            {
                if (anos < 15)
                {
                    salary = salary + (salary * (5.0 / 100.0));
                    Console.WriteLine("Novo Salário: " + salary);


                } //
                else if (anos >= 15 && anos <= 20)
                {
                    salary = salary + (salary * (12.0 / 100.0));
                    Console.WriteLine("Novo Salário: " + salary);
                }//
                else if (anos > 20)
                {
                    salary = salary + (salary * (23.0 / 100.0));
                    Console.WriteLine("Novo Salário: " + salary);
                }//
            }




            /*-Mulheres
            - menos de 15 anos de empresa: +5 %
            -de 15 até 20 anos de empresa: +12 %
            -mais de 20 anos de empresa: +23 %


            -Homens
            - menos de 20 anos de empresa: +3 %
            -de 20 até 30 anos de empresa: +13 %
            -mais de 30 anos de empresa: +25 %*/

        }
    }
}
