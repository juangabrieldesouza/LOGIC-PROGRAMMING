using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise59
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string resposta = "S", sexo = "";
            int cont = 1, idade = 0, maior = 0, homens = 0, menor = int.MaxValue, media = 0;

            while (resposta == "S")
            {

                if (cont == 1) Console.Write("Deseja registrar uma pessoa (s/n)? ");
                else Console.Write("Deseja registrar outra pessoa (s/n)? ");
                resposta = Console.ReadLine();
                resposta = resposta.ToUpper();

                if (resposta  == "S") 
                {

                    Console.Write("Digite o sexo da "+cont+"a. pessoa (F/M): ");
                    sexo = Console.ReadLine();
                    sexo = sexo.ToUpper();

                    Console.Write("Digite a idade da "+cont+"a. pessoa: ");
                    idade = int.Parse(Console.ReadLine());
                    
                    

                    if (maior < idade) maior = idade;

                    if (sexo == "M") { homens++; media = media + idade; }

                    if (sexo == "F" && idade < menor)
                    {
                        menor = idade;
                    }
                    else menor = 0;

                    
                }
    
                cont++;





            }

            media = media / homens;

            Console.WriteLine("Maior idade registrada: "+maior);
            Console.WriteLine("Quantidade de pessoas do sexo masculino calculado: "+homens);
            Console.WriteLine("Idade mais jovem cadastrada do sexo Feminino: "+ menor);
            Console.WriteLine("Média de idade dos homens: "+media);




        }
    }
}
