using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise34
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.Write("Digite seu peso (Kg): ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite a sua altura (metros): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            Console.WriteLine("--------------------------------");
            Console.WriteLine("Seu IMC: " + imc.ToString("F2"));
            if (imc < 18.5)
            {

                Console.WriteLine("Abaixo do peso ideal!");
            } else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Peso ideal!");
            } else if (imc >= 25 && imc < 30)
            {
                Console.WriteLine("Sobrepeso!");
            } else if (imc >= 30 && imc < 40)
            {
                Console.WriteLine("Obesidade!"); 
            } else if (imc >= 40) Console.WriteLine("Obesidade morbida!");

            /*abaixo de 18.5: Abaixo do peso
            - entre 18.5 e 25: Peso ideal
            -entre 25 e 30: Sobrepeso
             - entre 30 e 40: Obesidade
            - acima de 40: Obseidade mórbida*/

        }
    }
}
