using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kinoprojekciq
{
    class Program
    {
        static void Main(string[] args)
        {
            double result = 0;
            string vid = Console.ReadLine();
            int r = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (vid=="Premiere")
            {
                result = 12 * r * c;
                Console.WriteLine("{0:f2} leva",result);
            }
            else if (vid == "Normal")
            {
                result = 7.50 * r * c;
                Console.WriteLine("{0:f2} leva", result);
            }
            else if (vid == "Discount")
            {
                result = 5 * r * c;
                Console.WriteLine("{0:f2} leva", result);
            }
        }
    }
}
