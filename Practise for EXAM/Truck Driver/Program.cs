using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Truck_Driver
{
    class Program
    {
        static void Main(string[] args)
        {
            string sezon = Console.ReadLine();
            double km = double.Parse(Console.ReadLine());
            double pari = 0;
            if (km<=5000)
            {
                if (sezon=="Spring" || sezon=="Autumn")
                {
                    pari = (km * 0.75)*4*0.9;
                    Console.WriteLine("{0:F2}",pari);
                }
                else if (sezon == "Summer")
                {
                    pari = (km * 0.9) * 4 * 0.9;
                    Console.WriteLine("{0:F2}", pari);
                }
                else if (sezon == "Winter")
                {
                    pari = (km * 1.05) * 4 * 0.9;
                    Console.WriteLine("{0:F2}", pari);
                }
            }
            else if (km>5000 && km<=10000)
            {
                if (sezon == "Spring" || sezon == "Autumn")
                {
                    pari = (km * 0.95) * 4 * 0.9;
                    Console.WriteLine("{0:F2}", pari);
                }
                else if (sezon == "Summer")
                {
                    pari = (km * 1.1) * 4 * 0.9;
                    Console.WriteLine("{0:F2}", pari);
                }
                else if (sezon == "Winter")
                {
                    pari = (km * 1.25) * 4 * 0.9;
                    Console.WriteLine("{0:F2}", pari);
                }
            }
            else if (km>10000 && km<=20000)
            {
                if (sezon == "Spring" || sezon == "Autumn" || sezon=="Summer" || sezon=="Winter")
                {
                    pari = (km * 1.45) * 4 * 0.9;
                    Console.WriteLine("{0:F2}", pari);
                }
            }
        }
    }
}
