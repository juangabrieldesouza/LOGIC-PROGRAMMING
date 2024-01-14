using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise15
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-------------------------");
            Console.WriteLine(" Contagem RegreNicotina");
            Console.WriteLine("-------------------------");
            Console.Write("Quantos cigarros você fuma por dia? ");
            int cigarros = int.Parse(Console.ReadLine());

            Console.Write("E faz quantos anos que você fuma? ");
            int anosFumando = int.Parse(Console.ReadLine());
            int diasFumando;


            if (anosFumando >= 4)  diasFumando = anosFumando * 365 + 1;
            
            else diasFumando = anosFumando * 365;

            cigarros = diasFumando * cigarros;
            Console.WriteLine("A quantidade de cigarros fumados: "+cigarros);
            cigarros = ((cigarros * 10) / 60)/24;

            Console.WriteLine("Tempo de vida perdido: "+cigarros+" dias");



        }
    }
}
