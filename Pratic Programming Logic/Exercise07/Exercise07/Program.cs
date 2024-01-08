using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            

            Console.WriteLine("----------------------------------");
            Console.WriteLine("Unidades de medidas tipo DISTANCIA");
            Console.WriteLine("----------------------------------");
            Console.Write("Digite uma medida em metros: ");
            double metros = double.Parse(Console.ReadLine());

            double decimetros = (metros) * 10;
            double centimetros = ((metros) * 10) * 10;
            double milimetros = (((metros) * 10) * 10) * 10;

            double decametro = (metros) / 100;
            double hectometro = ((metros)/10) / 100;
            double kilometro = (((metros) / 10) / 10)/100;

            Console.WriteLine($"Valor em:\n decametro: {decametro.ToString("F2")}\n hectometro: {hectometro.ToString("F2")}\n kilometro: {kilometro.ToString("F2")}\n decimetros: {decimetros.ToString("F2")}\n centímetros: {centimetros.ToString("F2")}\n milímetros: {milimetros.ToString("F2")}");
            
        }
    }
}
