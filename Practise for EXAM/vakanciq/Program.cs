using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace vakanciq
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double cena = 0;
            string season = Console.ReadLine();
            if (budget<=1000)
            {
                if (season=="Summer")
                {
                    cena = budget * 0.65;
                    Console.WriteLine("Alaska - Camp - {0:F2}",cena);
                }
                else if (season=="Winter")
                {
                    cena = budget * 0.45;
                    Console.WriteLine("Morocco - Camp - {0:F2}", cena);
                }
            }
            else if (budget>1000 && budget<=3000)
            {
                if (season == "Summer")
                {
                    cena = budget * 0.8;
                    Console.WriteLine("Alaska - Hut - {0:F2}", cena);
                }
                else if (season == "Winter")
                {
                    cena = budget * 0.6;
                    Console.WriteLine("Morocco - Hut - {0:F2}", cena);
                }
            }
            else if (budget>3000)
            {
                if (season == "Summer")
                {
                    cena = budget * 0.9;
                    Console.WriteLine("Alaska - Hotel - {0:F2}", cena);
                }
                else if (season == "Winter")
                {
                    cena = budget * 0.9;
                    Console.WriteLine("Morocco - Hotel - {0:F2}", cena);
                }
            }
        }
    }
}
