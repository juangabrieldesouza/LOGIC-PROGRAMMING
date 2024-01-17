using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise24
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual a distância deseja percorrer (Km)? ");
            double distancia = double.Parse(Console.ReadLine());

           if (distancia >= 200) distancia = distancia * 0.45;

           else distancia = distancia * 0.5;

            Console.WriteLine(" O preço da viagem é R$"+distancia);
        }
    }
}
