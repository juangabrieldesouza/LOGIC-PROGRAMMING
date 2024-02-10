using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise53
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cont = 1, homens = 0, mulheres = 0, idade = 0, idadeM = 0, idadeF = 0;
            double mediaG = 0, mediaH = 0;
            string sexo = "";



            while (cont <= 5)
            {
                Console.Write("Digite a idade da "+cont+"o. pessoa: ");
                idade = int.Parse(Console.ReadLine());
                Console.Write("Digite o sexo da "+cont+"o. pessoa (F/M): ");
                sexo = Console.ReadLine();
                Console.WriteLine("---------------------------------------");

                sexo = sexo.ToUpper();

                if (sexo == "M") homens++;

                if (sexo == "F") mulheres++;

                if (sexo == "F" && idade > 20) idadeF++;

                if (sexo == "M") idadeM += idade;

                mediaG += idade;

                cont++;
            }

            mediaH = idadeM / homens;
            mediaG = mediaG / 5.0;

            Console.WriteLine("Quantidades de homens cadastrados: "+homens);
            Console.WriteLine("Quantidade de mulheres cadastrados: "+mulheres);
            Console.WriteLine("Media da idade do grupo: "+mediaG);
            Console.WriteLine("Media da idade dos homens: " + mediaH);
            Console.WriteLine("Quantidade de mulheres com mais de 20 anos: "+idadeF);

        }
    }
}
