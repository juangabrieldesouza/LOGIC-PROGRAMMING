using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("   Radar topzera");
            Console.WriteLine("-------------------");
            Console.Write("Qual é a Quilometragem do carro? ");
            int velocidade = int.Parse(Console.ReadLine());


            Console.WriteLine("==============STATUS=============");
            if ( velocidade >=80 ) 
            {
                Console.WriteLine("Limite de velocidade Ultrapassada!");
                Console.WriteLine("VELOCIDADE: "+velocidade);
                Console.WriteLine("------------------------");

                velocidade = velocidade * 5;

                Console.WriteLine("Multa por excesso de velocidade: R$"+velocidade);


            }
            Console.WriteLine("===========================");
        }
    }
}
