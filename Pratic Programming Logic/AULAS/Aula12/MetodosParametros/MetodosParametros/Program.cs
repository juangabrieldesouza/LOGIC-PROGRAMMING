using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetodosParametros
{
    internal class Program
    {
        static void Main(string[] args)
        {
            soma(2, 14);

        }

        static void soma(int a, int b)
        {
            Console.WriteLine("Recebi o valor "+a);
            Console.WriteLine("Recevi o valor "+ b);
            Console.WriteLine("A somo de "+a+" + "+b+" é "+(a+b));
        }
    }
}
