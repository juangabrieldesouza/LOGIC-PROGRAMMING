using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o sexo do cliente? (FF/MM):  ");
            String sexo = Console.ReadLine();
            Console.Write("Digite o valor da compra: R$");
            double compra = double.Parse(Console.ReadLine());
            Console.WriteLine("---------------");
            Console.WriteLine("Valor da compra: R$"+compra.ToString("F2"));
            double valorTotal = compra - (compra * (13.0 / 100.0));
            double desconto =  (13.0 / 100.0) * compra;

            if (sexo == "FF")
            {
                Console.WriteLine("DESCONTO: R$"+desconto.ToString("F2"));
                Console.WriteLine("VALOR TOTAL DA COMPRA: R$" + valorTotal.ToString("F2"));

            } else if (sexo == "MM")
            {
                Console.WriteLine("DESCONTO: R$" + compra * (5.0 / 100.0));
                Console.WriteLine("VALOR TOTAL DA COMPRA: R$" + valorTotal.ToString("F2"));
            }
                

        }
    }
}
