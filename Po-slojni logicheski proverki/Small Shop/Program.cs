using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var city = Console.ReadLine().ToLower();
            double kolichestvo = double.Parse(Console.ReadLine());
            if (city == "sofia")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(kolichestvo * 0.5);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.8 * kolichestvo);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(kolichestvo * 1.2);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(kolichestvo * 1.45);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(kolichestvo * 1.6);
                }
            }
            if (city == "plovdiv")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(kolichestvo * 0.4);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.7 * kolichestvo);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(kolichestvo * 1.15);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(kolichestvo * 1.3);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(kolichestvo * 1.5);
                }
            }
            if (city == "varna")
            {
                if (product == "coffee")
                {
                    Console.WriteLine(kolichestvo * 0.45);
                }
                else if (product == "water")
                {
                    Console.WriteLine(0.7 * kolichestvo);
                }
                else if (product == "beer")
                {
                    Console.WriteLine(kolichestvo * 1.1);
                }
                else if (product == "sweets")
                {
                    Console.WriteLine(kolichestvo * 1.35);
                }
                else if (product == "peanuts")
                {
                    Console.WriteLine(kolichestvo * 1.75);
                }
            }
        }
    }
}
