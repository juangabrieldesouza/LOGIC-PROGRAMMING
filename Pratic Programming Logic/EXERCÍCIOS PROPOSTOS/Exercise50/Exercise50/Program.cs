using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise50
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Random random = new Random();
            int[] numerosSorteados = new int[20];

            int numeroAcima = 0;

            int numeroDiv = 0;

            for (int i = 0; i < numerosSorteados.Length; i++)
            {
                numerosSorteados[i] = random.Next(1, 11); // Gerar número aleatório entre 1 e 10

                if (numerosSorteados[i] > 5) numeroAcima ++;

                if (numerosSorteados[i] % 3 == 0) numeroDiv ++;
            }

            // Exibir os números sorteados
            Console.WriteLine("Números sorteados:");

            foreach (int numero in numerosSorteados)
            {
                Console.Write(numero + " ");


            }
           
            Console.WriteLine("\nNúmeros acima de 5: " + numeroAcima);
            Console.WriteLine("Números divisiveis por 3: "+numeroDiv);



        }
    }
}
