using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise51
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double produtoMenor = int.MaxValue, produtoMaior = 0, produto = 0, cont = 1;
            

            while (cont <= 8) 
            {
                Console.Write("Digite o preço do "+cont+ "o. produto: R$");
                produto = double.Parse(Console.ReadLine());

                if (produtoMaior < produto) produtoMaior = produto;

                if (produto < produtoMenor) produtoMenor = produto;

                cont++; 


            }

            Console.WriteLine("O menor valor digitado foi de R$"+produtoMenor);
            Console.WriteLine("O maior valor digitado foi de R$"+produtoMaior);


        }
    }
}
