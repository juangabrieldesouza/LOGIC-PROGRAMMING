using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise57
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string resposta = "S", sexo = "";
            int contador = 1;
            double homens = 0, mulheres = 0;


            do
            {
                Console.Write("Digite o Salário do "+contador+ "o. funcionário: R$");
                double salario = double.Parse(Console.ReadLine());
                Console.Write("Digite o sexo do "+contador+ "o. Funcionário (M/F): ");
                sexo = Console.ReadLine();
                sexo = sexo.ToUpper();
                Console.WriteLine("----------------------------------------------------");
                Console.WriteLine("Deseja continuar? (S/N)");
                resposta = Console.ReadLine();

                if (sexo == "M") homens = homens + salario;

                if (sexo == "F") mulheres = mulheres + salario;

                resposta = resposta.ToUpper();
                contador ++;
            } while (resposta == "S");

            Console.WriteLine("Total pago aos homens: R$"+homens );
            Console.WriteLine("Total pago as mulheres: R$"+mulheres);

        }
    }
}
