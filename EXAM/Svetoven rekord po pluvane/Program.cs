using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svetoven_rekord_po_pluvane
{
    class Program
    {
        static void Main(string[] args)
        {
            var recinsec = decimal.Parse(Console.ReadLine());
            var metri = decimal.Parse(Console.ReadLine());
            var vremezametyr = decimal.Parse(Console.ReadLine());
            decimal result = 0;
            result = metri * vremezametyr;
            decimal dobavqne = 0;
            dobavqne =(metri / 15);
            dobavqne = dobavqne * 12.50m;
            result += dobavqne;
            if (result<recinsec)
            {

                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.",result);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.",Math.Abs(recinsec-result));
            }
        }
    }
}
