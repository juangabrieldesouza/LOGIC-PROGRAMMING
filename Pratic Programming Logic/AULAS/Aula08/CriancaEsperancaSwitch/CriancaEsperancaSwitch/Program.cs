using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CriancaEsperancaSwitch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("  CRIANÇA ESPERANÇA");
            Console.WriteLine("-----------------------");
            Console.WriteLine("Muito obrigado por ajudar");
            Console.WriteLine(" [1] para doar 10R$ ");
            Console.WriteLine(" [2] para doar R$25 ");
            Console.WriteLine(" [3] para doar R$50 ");
            Console.WriteLine(" [4] para doar outros valores" );
            Console.WriteLine(" [5] para cancelar");
            int opcao = int.Parse( Console.ReadLine() );

            switch ( opcao )
            {
                case 1: opcao = 10;
                    break;
                case 2: opcao = 25;
                    break;
                case 3: opcao = 50;
                    break;
                case 4:
                    Console.Write("Qual o valor da doação? R$");
                    opcao = int.Parse( Console.ReadLine() );
                    break;
                case 5:
                    opcao = 0;
                    break;
            }
            Console.WriteLine("--------------------------");
            Console.WriteLine(" Sua doação foi de R$" + opcao + "\nMuito obrigado por ajudar");
            Console.WriteLine("--------------------------");
            //   /  \
        }
    }
}
