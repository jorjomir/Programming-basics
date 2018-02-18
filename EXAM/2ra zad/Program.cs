using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2ra_zad
{
    class Program
    {
        static void Main(string[] args)
        {
            double recinsecs = double.Parse(Console.ReadLine());
            double razstoqnie = double.Parse(Console.ReadLine());
            double vremezametyr = double.Parse(Console.ReadLine());
            double sekundi = razstoqnie * vremezametyr;
            double dobaveno = Math.Floor(razstoqnie / 15) * 12.5;
            sekundi += dobaveno;
            if (sekundi<recinsecs)
            {
                Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.",sekundi);
            }
            else
            {
                Console.WriteLine("No, he failed! He was {0:F2} seconds slower.",sekundi-recinsecs);
            }
        }
    }
}
