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
            Console.WriteLine("Valor da compra: R$"+compra);
            double valorTotal = compra - (compra * (13 / 100));
            double desconto =  (13 / 100) * compra;

            if (sexo == "FF")
            {
                Console.WriteLine("DESCONTO: R$"+desconto);
                Console.WriteLine("VALOR TOTAL DA COMPRA: R$" + valorTotal);

            } else if (sexo == "MM")
            {
                Console.WriteLine("DESCONTO: R$" + compra * (5 / 100));
                Console.WriteLine("VALOR TOTAL DA COMPRA: R$" + valorTotal);
            }
                

        }
    }
}
