using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise41
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 100;
            while (c >= 85)
            {
                Console.Write(" "+c);
                c-=5;
            }
            Console.Write(" ... 0 Acabou!");
            Console.WriteLine();

        }
    }
}
