using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;

namespace EscolhendoPessoas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pessoasM=0;
            int pessoasF=0;
            string resposta = "";
            string sexo = "";
            int idade = 0;
            int cabelo = 1;
            Console.WriteLine("=======================");
            Console.WriteLine("  SELETOR DE PESSOAS  ");
            Console.WriteLine("=======================");

            do
            {
                Console.Write("Qual o sexo (F/M)? ");
                sexo = Console.ReadLine();
                Console.Write("Qual a idade? ");
                idade = int.Parse(Console.ReadLine());
                Console.WriteLine("Qual a cor do cabelo?");
                Console.WriteLine("------------------------");
                Console.WriteLine(" [1] Castanho");
                Console.WriteLine(" [2] Preto");
                Console.WriteLine(" [3] Loiro");
                Console.WriteLine(" [4] Ruivo");
                cabelo = int.Parse(Console.ReadLine());
                Console.WriteLine("Quer continuar (S/N)? ");
                resposta = Console.ReadLine();
                if (sexo == "M" && idade > 18 && cabelo == 1) pessoasM++;

                else if (sexo == "F" && idade > 25 && idade < 30 && cabelo == 3) pessoasF++;
                Console.Clear();
            } while (resposta != "N");

            
            Console.WriteLine("Quantidade de Homens, mais de 18 anos, cabelo castanho: " + pessoasM);
            Console.WriteLine("Quantidade de mulheres, entre 25 e 30 anos, loiras: "+pessoasF);
        }
    }
}
