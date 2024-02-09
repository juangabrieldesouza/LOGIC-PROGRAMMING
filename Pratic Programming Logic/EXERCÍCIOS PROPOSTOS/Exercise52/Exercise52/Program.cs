using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise52
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, menos = 0, maiorIdade = 0, maisDeDezoito = 0, idade = 0, media = 0;


            while (cont <= 10)
            {
                Console.Write("Digite a "+cont+"o. idade: ");
                idade = int.Parse(Console.ReadLine());

                if (idade > maiorIdade) maiorIdade = idade;

                if (idade < 5) menos++;

                if (idade > 18) maisDeDezoito++;

                media += idade;



                cont++;
            }

            Console.WriteLine("Média de idades do grupo: "+(media/10));
            Console.WriteLine("Quantidade de pessoas maiores de 18 anos: "+maisDeDezoito);
            Console.WriteLine("Quantidade de pessoas menor que 5 anos: "+menos);
            Console.WriteLine("Maior idade inserida: "+maiorIdade);


        }
    }
}
