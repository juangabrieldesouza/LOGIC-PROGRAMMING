using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise54
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int cont = 1;
            double altura = 0, peso = 0, mediaAltura = 0, mais = 0, menos = 0, maisMais = 0;


            while (cont <= 7)
            {
                Console.Write("Digite a altura da "+cont+"o. pessoa em metros: ");
                altura = double.Parse(Console.ReadLine());
                Console.Write("Digite o peso dessa pessoa (KG): ");
                peso = double.Parse(Console.ReadLine());
                Console.WriteLine("--------------------------");

                if (peso > 90) mais++;

                if (peso < 50 && altura < 1.60) menos++;

                if (peso > 100 && altura > 1.90) maisMais++;

                mediaAltura += altura;

                cont++;
            }

            mediaAltura = mediaAltura / 7.0;

            Console.WriteLine("Media da altura do grupo: "+mediaAltura.ToString("F2"));
            Console.WriteLine("Pessoas que pesam mais de 90KG: "+mais);
            Console.WriteLine("Pessoas com menos de 50Kg e com menos de 1,60m: "+menos);
            Console.WriteLine("Pessoas com mais de 1,90m e com mais de 100Kg: "+maisMais);

        }
    }
}
