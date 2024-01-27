using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise43
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int c = 30;
            while (c >0)
            {
                if (c % 4 ==0) 
                {
                    Console.Write(" {"+$"{c}"+"}");
                } else Console.Write(" "+c);
                c--;
            }
            Console.WriteLine();
        }
    }
}
