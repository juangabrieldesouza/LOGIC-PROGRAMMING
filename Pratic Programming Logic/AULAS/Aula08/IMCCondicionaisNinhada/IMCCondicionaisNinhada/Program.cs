using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IMCCondicionaisNinhada
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("----------------------");
            Console.WriteLine("      CÁLCULO IMC");
            Console.WriteLine("----------------------");

            Console.Write("Massa (KG): ");
            float massa = float.Parse(Console.ReadLine());

            Console.Write("Altura (cm): ");
            float altura = float.Parse(Console.ReadLine());

            altura = altura / 100;
            double IMC = massa / Math.Pow(altura, 2);
            Console.WriteLine("---------STATUS-------");
            Console.WriteLine("IMC: "+IMC.ToString("F2"));
            if (IMC < 17) 
            {
                Console.WriteLine("Você está muito abaixo do peso, cuide-se :/");


            } else if (IMC >=17 && IMC < 18.5)
            {
                Console.WriteLine("Você está abaixo do seu peso ideal");


            }else if (IMC >=18.5 &&  IMC <= 25)
            {
                Console.WriteLine("Você se encontra em seu peso ideal");
            }else if (IMC > 25 && IMC < 30)
            {
                Console.WriteLine("Você se encotra no sobre peso");
            }else if (IMC >= 30 && IMC < 35)
            {
                Console.WriteLine("Você se encotra em obesidade");
            }else if (IMC >= 35 && IMC < 40)
            {
                Console.WriteLine("Você se encontra em obesidade severa, busque ajuda :/");
            }else if (IMC >= 40)
            {
                Console.WriteLine("Você se encontra em obesidade morbida, por favor cuide-se :/");
            }

            Console.WriteLine("---------------------");

            //   /  \
        }
    }
}
