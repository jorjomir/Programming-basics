using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magazin_za_plodove
{
    class Program
    {
        static void Main(string[] args)
        {
            double cena = -1.0;
            string plod =Console.ReadLine().ToLower();
            string den = Console.ReadLine().ToLower();
            double kolichestvo = double.Parse(Console.ReadLine());
            if(den=="monday" || den == "tuesday" || den == "wednesday" || den == "thursday" || den == "friday")
            {
                if (plod=="banana")
                {
                    cena = kolichestvo * 2.5;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
                else if (plod == "apple")
                {
                    cena = kolichestvo * 1.2;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
                else if (plod == "orange")
                {
                    cena = kolichestvo * 0.85;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
                else if (plod == "grapefruit")
                {
                    cena = kolichestvo * 1.45;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
                else if (plod == "kiwi")
                {
                    cena = kolichestvo * 2.7;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
                else if (plod == "pineapple")
                {
                    cena = kolichestvo * 5.5;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
                else if (plod == "grapes")
                {
                    cena = kolichestvo * 3.85;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
            }
            else if(den=="saturday" || den=="sunday")
            {
                if (plod == "banana")
                {
                    cena = kolichestvo * 2.7;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
                else if (plod == "apple")
                {
                    cena = kolichestvo * 1.25;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
                else if (plod == "orange")
                {
                    cena = kolichestvo * 0.9;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
                else if (plod == "grapefruit")
                {
                    cena = kolichestvo * 1.6;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
                else if (plod == "kiwi")
                {
                    cena = kolichestvo * 3;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
                else if (plod == "pineapple")
                {
                    cena = kolichestvo * 5.6;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
                else if (plod == "grapes")
                {
                    cena = kolichestvo * 4.2;
                    cena = Math.Round(cena, 2);
                    Console.WriteLine(cena);
                }
            }
            else { Console.WriteLine("error"); }
        }

    }
}
