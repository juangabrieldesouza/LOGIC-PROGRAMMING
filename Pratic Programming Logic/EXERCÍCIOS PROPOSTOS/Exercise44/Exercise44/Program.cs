using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise44
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o primeiro valor: ");
            int valor = int.Parse(Console.ReadLine());
            Console.Write("Digite o ultimo valor: ");
            int ultValor = int.Parse(Console.ReadLine());
            Console.Write("Digite o incremento valor: ");
            int incremento = int.Parse(Console.ReadLine());

            while (valor <= ultValor)
            {
                Console.Write(" "+valor);
                valor += incremento;
            }
            Console.WriteLine(" Acabou!");
        }
    }
}
