using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------");
            Console.WriteLine("Especiarias Souza");
            Console.WriteLine("-----------------");

            Console.Write("Digite o valor do produto: ");
            double precoProduto = double.Parse(Console.ReadLine());

            double valorProduto = 5 * (precoProduto / 100);
            double valorTotal = precoProduto - valorProduto;


            Console.WriteLine("---------NOTA-------");

            Console.WriteLine("Valor do produto: "+precoProduto);
            Console.WriteLine("Valor do desconto: "+valorProduto);
            Console.WriteLine("Novo valor total: " + valorTotal);
        }
    }
}
