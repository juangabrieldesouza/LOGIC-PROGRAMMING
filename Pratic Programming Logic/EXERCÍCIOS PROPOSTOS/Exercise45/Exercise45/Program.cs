using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise45
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

            if (valor <= ultValor) 
            { 
                while (valor <= ultValor)
                {
                    Console.Write(" " + valor);
                    valor += incremento;
                }
                Console.WriteLine(" Acabou!");

            } else if (ultValor  <= valor) 
            {
                while (valor >= ultValor)
                {
                    Console.Write(" " + valor);
                    valor -= incremento;
                }
                Console.WriteLine(" Acabou!");

            }
        }
    }
}
