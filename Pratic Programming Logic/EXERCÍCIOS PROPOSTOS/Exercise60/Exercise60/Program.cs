using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Exercise60
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int cont = 1, idade = 0, homens = 0, mulheres = 0, idadeTotal= 0, idade2 = 0, idadeMenor = int.MaxValue;
            string nome = null, sexo = null, resposta = "S", pessoaMaior = "", nomeMenor = "";

            while(resposta == "S")     
            {
                if (cont == 1) Console.Write("Você deseja cadastrar uma pessoa (s/n)? ");
                else Console.Write("Quer continuar(s/n)? ");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();


                if (resposta == "S") 
                {
                    Console.WriteLine("==========================================");
                    Console.WriteLine("              PESSOA "+cont+"             ");
                    Console.WriteLine("==========================================");
                    Console.Write("Digite o nome da "+cont+"a. pessoa: ");
                    nome = Console.ReadLine();
                    Console.Write("Digite a idade: ");
                    idade = int.Parse(Console.ReadLine());
                    Console.Write("Digite o sexo da pessoa (F/M): ");
                    sexo = Console.ReadLine();
                    sexo = sexo.ToUpper();
                    Console.WriteLine("------------------------------------");
                    idadeTotal = idadeTotal + idade;

                    if (idade > 30 && sexo == "M") homens++;

                    if (idade < 18 && sexo == "F") mulheres++;

                    

                    if (idade2 < idade)
                    {
                        
                        pessoaMaior = nome;
                    }

                    idade2 = idade;

                    if (idade < idadeMenor)
                    { 
                        idadeMenor = idade; 
                        if (sexo == "F") 
                        {
                            nomeMenor = nome;
                        }
                    }
                }

                cont++;



            }

            Console.WriteLine("--------------------------------------");

            Console.WriteLine("A pessoa mais velha registrada é "+pessoaMaior);
            Console.WriteLine("A mulher mais jovem é a "+nomeMenor);
            Console.WriteLine("Média de idade do grupo é de "+(idadeTotal/cont));
            Console.WriteLine("Total de homens com mais de 30 anos é "+homens);
            Console.WriteLine("A quantidade de mulheres com menos de 18 anos é "+mulheres);




        }
    }
}
