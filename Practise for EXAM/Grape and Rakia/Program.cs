using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grape_and_Rakia
{
    class Program
    {
        static void Main(string[] args)
        {
            var plosht = double.Parse(Console.ReadLine());
            var kg = double.Parse(Console.ReadLine());
            var brak = double.Parse(Console.ReadLine());
            double rakiq = (plosht * kg)-brak;
            double grozde = rakiq;
            rakiq = rakiq * 0.45;
            rakiq =(rakiq/7.5)*9.8;
            rakiq = Math.Round(rakiq,2);
            grozde = (grozde * 0.55)*1.5;
            grozde = Math.Round(grozde, 2);
            Console.WriteLine($"{rakiq:F2}");
            Console.WriteLine($"{grozde:F2}");
        }
    }
}
