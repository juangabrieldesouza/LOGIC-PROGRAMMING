using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise32
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int numero = random.Next(1,5);
            Console.Write("Advinhe o número de 1 a 5: ");
            int escolha = int.Parse(Console.ReadLine());

            if (escolha == numero) 
            {
                Console.WriteLine("ACERTOU!! PARABÉNS!!");
            } else if (escolha != numero && escolha > 1 && escolha <= 5) 
            {
                Console.WriteLine("Infelizmente você errou!");
            } else Console.WriteLine("VALOR INSERIDO INVÁLIDO!");

            if (escolha > 1 && escolha <= 5) Console.WriteLine("Número correto: "+numero);
        }
    }
}
