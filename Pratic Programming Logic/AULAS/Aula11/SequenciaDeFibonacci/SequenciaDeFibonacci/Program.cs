using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SequenciaDeFibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int atual = 1;
            int proximo = 1;
            int anterior = 0;
            int total = 0;

            Console.Write("Digite quantidade: ");
            total = int.Parse(Console.ReadLine());
            for (int i = 1; i < total; i++) 
            {
                Console.WriteLine(proximo);
                proximo = atual + anterior;
                anterior = atual;
                atual = proximo;
            }
        }
    }
}
