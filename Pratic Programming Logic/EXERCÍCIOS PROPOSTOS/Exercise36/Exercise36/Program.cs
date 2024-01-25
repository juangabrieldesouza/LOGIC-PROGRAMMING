using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise36
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double pontos = 0;
            
            double dinheiro = 0.5 * pontos;
            
            
            Console.Write("Digite as horas em atividade Física: ");
            int horas = int.Parse(Console.ReadLine());

            if (horas <= 10)
            {
                pontos = 2 * horas;
                dinheiro = 0.5 * pontos;
                Console.WriteLine("Número de pontos: " + pontos);
                Console.WriteLine("Ganho total: R$" + dinheiro.ToString("F2"));




            } else if (horas > 10 && horas <= 20)
            {
                pontos = 5 * horas;
                dinheiro = 0.5 * pontos;
                Console.WriteLine("Número de pontos: " + pontos);
                Console.WriteLine("Ganho total: R$" + dinheiro.ToString("F2"));




            } else if ( horas > 20 ) 
            {
                pontos = 10 * horas;
                dinheiro = 0.5 * pontos;
                Console.WriteLine("Número de pontos: "+pontos);
                Console.WriteLine("Ganho total: R$" + dinheiro.ToString("F2"));



            }

            /*-Cada hora de atividade física no mês vale pontos
             * 
            -até 10h de atividade no mês: ganha 2 pontos por hora

            - de 10h até 20h de atividade no mês: ganha 5 pontos por hora

            - acima de 20h de atividade no mês: ganha 10 pontos por hora

            - A cada ponto ganho, o cliente fatura R$0,05(5 centavos)*/


        }
    }
}
