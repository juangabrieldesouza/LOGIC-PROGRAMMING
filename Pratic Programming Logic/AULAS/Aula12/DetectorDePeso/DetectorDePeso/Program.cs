using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DetectorDePeso
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string nomeGanhador="";
            double maiorPeso = 0;
            topo();
            for (int i = 1; i < 5; i++)
            {
                Console.Write("Digite o nome: ");
                string nome = Console.ReadLine();
                Console.Write("Digite o peso de "+nome+": ");
                double peso = double.Parse(Console.ReadLine());
                if (peso > maiorPeso) { maiorPeso = peso; nomeGanhador = nome; }
                topo();
            }
            topo();
            Console.WriteLine("O maior peso foi de "+nomeGanhador+" com "+maiorPeso+"Kg");


            void topo()
            {
                Console.Clear();
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("D E T E C T O R  D E  P E S O");
                Console.WriteLine("Maior peso até agora: " + maiorPeso + "Kg");
                Console.WriteLine("-------------------------------------");
            }

        }
        
    }
}
