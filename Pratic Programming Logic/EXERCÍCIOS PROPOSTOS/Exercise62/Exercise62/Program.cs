using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise62
{
    internal class Program
    {
        static void Main(string[] args)
        {


            string resposta = "S";
            int idades = 0;
            double media = 0;
            int maiores = 0;
            int idade = 0;


            do
            {
                if (idades == 0) Console.Write("Insira uma idade: ");

                else Console.Write("Digite a idade de outra pessoa: ");

                idade = int.Parse(Console.ReadLine());

                idades++;

                media = idade + media;

                if (idade >= 21) maiores++;

                Console.Write("Deseja continuar? (s/n) ");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();
                Console.WriteLine("---------------------------");
            } while (resposta == "S");

            Console.WriteLine("Quantidade de idades digitadas: "+idades);
            Console.WriteLine("Média das idades digitadas: " + (media/idades));
            Console.WriteLine("Pessoas com 21 anos ou mais: "+maiores);

        }
    }
}
