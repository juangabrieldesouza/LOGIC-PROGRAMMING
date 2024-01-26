using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 10;

            while (c >= 3)
            {
                Console.Write(" "+c);
                c--;
            }
            Console.WriteLine(" Acabou!");
        }
    }
}
