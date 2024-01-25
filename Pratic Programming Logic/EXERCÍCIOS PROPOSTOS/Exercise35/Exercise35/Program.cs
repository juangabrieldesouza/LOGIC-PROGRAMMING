using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise35
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|        TRACY CAR'S        |");
            Console.WriteLine("|---------------------------|");
            Console.WriteLine("|      ESCOLHA UMA OPCAO    |");
            Console.WriteLine("|                           |");
            Console.WriteLine("| [1] CARRO POPULAR         |");
            Console.WriteLine("| [2] CARRO DE LUXO         |");
            Console.WriteLine("|---------------------------|");
            int op = int.Parse(Console.ReadLine());
            double carroP = 90;
            double carroL = 150;
            Console.WriteLine("--------------------------------");
            Console.WriteLine("Quantos dias de uso do carro?");
            double dias = double.Parse(Console.ReadLine());
            Console.Write("Qual a distancia de uso (km): ");
            double km = double.Parse(Console.ReadLine());
            Console.WriteLine("--------------------------------");
            double total = 0.0;
            double diasP = dias * carroP;
            double kmP = km * 0.20;


            if (op == 1)
            {
                
                if (km > 100)
                {
                    diasP = dias * carroP;
                    kmP = km * 0.10;
                    total = kmP + diasP;
                    Console.WriteLine("TOTAL DE KM: R$"+kmP);
                    Console.WriteLine("TOTAL DE DIAS: R$"+diasP);
                    Console.WriteLine("PRECO TOTAL: "+total);

                }
                else
                {
                    diasP = dias * carroP;
                    kmP = km * 0.20;
                    total = kmP + diasP;
                    Console.WriteLine("TOTAL DE KM: R$" + kmP);
                    Console.WriteLine("TOTAL DE DIAS: R$" + diasP);
                    Console.WriteLine("PRECO TOTAL: " + total);

                }
            } else if (op == 2)
            {
                
                if (km > 200)
                {
                    diasP = dias * carroL;
                    kmP = km * 0.25;
                    total = kmP + diasP;
                    Console.WriteLine("TOTAL DE KM: R$" + kmP);
                    Console.WriteLine("TOTAL DE DIAS: R$" + diasP);
                    Console.WriteLine("PRECO TOTAL: " + total);

                }
                else
                {
                    diasP = dias * carroL;
                    kmP = km * 0.30;
                    total = kmP + diasP;
                    Console.WriteLine("TOTAL DE KM: R$" + kmP);
                    Console.WriteLine("TOTAL DE DIAS: R$" + diasP);
                    Console.WriteLine("PRECO TOTAL: " + total);

                }
            }

            /*-Carros populares(aluguel de R$90 por dia)
            - Até 100Km percorridos: R$0,20 por Km
            -Acima de 100Km percorridos: R$0,10 por Km

            -Carros de luxo(aluguel de R$150 por dia)
             -Até 200Km percorridos: R$0,30 por Km
            -Acima de 200Km percorridos: R$0,25 por Km*/

        }
    }
}
