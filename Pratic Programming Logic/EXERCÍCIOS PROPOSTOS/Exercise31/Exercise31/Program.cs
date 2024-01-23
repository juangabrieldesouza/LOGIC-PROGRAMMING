using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise31
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int alenum = random.Next(1,3);
            string escolha;
            string escolhaplayer;
            Console.WriteLine("-------------------------");
            Console.WriteLine("     JO - KEN - PO");
            Console.WriteLine("-------------------------");

            Console.WriteLine(" [1] PEDRA ");
            Console.WriteLine(" [2] PAPEL ");
            Console.WriteLine(" [3] TESOURA ");

            Console.Write("Digite o número da sua escolha: ");
            int numero = int.Parse(Console.ReadLine());

            switch (alenum)
            {
                case 1:
                    escolha = "PEDRA";
                    break;
                case 2:
                    escolha = "PAPEL";
                    break; 
                case 3:
                    escolha = "TESOURA";
                    break;
                default:
                    escolha = null;
                    break;  
            }
            switch (numero)
            {
                case 1:
                    escolhaplayer = "PEDRA";
                    break;
                case 2:
                    escolhaplayer = "PAPEL";
                    break;
                case 3:
                    escolhaplayer = "TESOURA";
                    break;
                default:
                    escolhaplayer = null;
                    break;
            }


            if (numero > 0 && numero <= 3 && alenum > 0 && alenum <= 3 && escolha != null && escolhaplayer != null)
            {
                Console.WriteLine("--------------STATUS-------------");
                Console.WriteLine("MÁQUINA: "+escolha);
                Console.WriteLine("JOGADOR: "+escolhaplayer);
                Console.WriteLine("---------------------------------");
                if (numero == alenum)
                {
                    Console.WriteLine("RESULTADO: EMPATE!");
                } else if( numero == 1 && alenum == 2)
                {
                    Console.WriteLine("RESULTADO: MÁQUINA VENCEDOR!");
                } else if (numero == 2 && alenum == 1)
                {
                    Console.WriteLine("RESULTADO: JOGADOR VENCEDOR");
                } else if (numero == 3 && alenum == 2)
                {
                    Console.WriteLine("RESULTADO: JOGADOR VENCEDOR!");
                } else if (numero == 2 && alenum == 3)
                {
                    Console.WriteLine("RESULTADO: MÁQUINA VENCEDOR!");
                } else if (numero == 1 && alenum == 3 )
                {
                    Console.WriteLine("RESULTADO: JOGADOR VENCEDOR!");
                }
                else if (numero == 3 && alenum == 1)
                {
                    Console.WriteLine("RESULTADO: MÁQUINA VENCEDOR!");
                }
                Console.WriteLine();
            }
            else Console.WriteLine("VALORES INVÁLIDOS!\n");





        }
    }
}
