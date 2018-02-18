using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stiropor
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double kyshta = double.Parse(Console.ReadLine());
            int prozorci = int.Parse(Console.ReadLine());
            double paket = double.Parse(Console.ReadLine());
            double cenapaket = double.Parse(Console.ReadLine());
            double obshtacena = kyshta - (prozorci * 2.4);
            obshtacena += obshtacena*0.1;
            obshtacena = obshtacena / paket;
            obshtacena = Math.Ceiling(obshtacena);
            obshtacena = obshtacena * cenapaket;
            if (obshtacena<=budget)
            {
                Console.WriteLine("Spent: {0:F2}",obshtacena);
                Console.WriteLine("Left: {0:F2}",budget-obshtacena);
            }
            else
            {

                Console.WriteLine("Need more: {0:F2}",Math.Abs(budget-obshtacena));
            }
        }
    }
}
