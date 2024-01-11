using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartidaDeFutebol
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------");
            Console.WriteLine("Várzea grande x Cuiabá");
            Console.WriteLine("-----------------------");

            Console.Write("Quantos gols fez VG? ");
            int golVg = int.Parse(Console.ReadLine());

            Console.Write("Quantos gols Cuiabá fez? ");
            int golCuiaba = int.Parse(Console.ReadLine());

            int golTotal = 0;

            if ((golCuiaba == golVg) && (golCuiaba >= 0 && golVg >= 0)) golTotal = 1;

            else if ((golVg < golCuiaba && golCuiaba - golVg < 5 && golCuiaba - golVg > 0) || (golVg > golCuiaba && golVg - golCuiaba < 5 && golVg - golCuiaba > 0)) golTotal = 2;

            else if ((golVg < golCuiaba && golCuiaba - golVg > 5) || (golVg > golCuiaba && golVg - golCuiaba > 5)) golTotal = 3;

            else golTotal = 0;
            Console.WriteLine("----------------------------");
            switch (golTotal)
            {
                case 1: Console.WriteLine("CUIABÁ: " + golCuiaba + "\nVÁRZEA GRANDE: " + golVg); Console.WriteLine("EMPATE"); break;
                case 2: Console.WriteLine("CUIABÁ: " + golCuiaba + "\nVÁRZEA GRANDE: " + golVg); Console.WriteLine("GOLEADA"); break;
                case 3: Console.WriteLine("CUIABÁ: " + golCuiaba + "\nVÁRZEA GRANDE: " + golVg); Console.WriteLine("GOLEADA"); break;
            }
            Console.WriteLine("----------------------------");


        }
    }
}
