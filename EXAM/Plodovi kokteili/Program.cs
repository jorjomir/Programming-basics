using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Plodovi_kokteili
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string type = Console.ReadLine();
            int n = int.Parse(Console.ReadLine());
            double cena = 0;
            if (type=="small")
            {
                if (fruit=="Watermelon")
                {
                    cena = 2 * 56*n;
                    if (cena > 1000)
                    {
                        cena = cena / 2;
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena >= 400 && cena <= 1000)
                    {
                        cena = cena - (cena * 0.15);
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena < 400)
                    {
                        Console.WriteLine("{0:F2} lv.",cena);
                    }
                }
                else if (fruit == "Mango")
                {
                    cena = 2 * 36.66 * n;
                    if (cena > 1000)
                    {
                        cena = cena / 2;
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena >= 400 && cena <= 1000)
                    {
                        cena = cena - (cena * 0.15);
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena < 400)
                    {
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                }
                else if (fruit == "Pineapple")
                {
                    cena = 2 * 42.10 * n;
                    if (cena > 1000)
                    {
                        cena = cena / 2;
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena >= 400 && cena <= 1000)
                    {
                        cena = cena - (cena * 0.15);
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena < 400)
                    {
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                }
                else if (fruit == "Raspberry")
                {
                    cena = 2 * 20 * n;
                    if (cena > 1000)
                    {
                        cena = cena / 2;
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena >= 400 && cena <= 1000)
                    {
                        cena = cena - (cena * 0.15);
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena < 400)
                    {
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                }
            }
            else if (type=="big")
            {
                if (fruit == "Watermelon")
                {
                    cena = 5 * 28.70 * n;
                    if (cena > 1000)
                    {
                        cena = cena / 2;
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena >= 400 && cena <= 1000)
                    {
                        cena = cena - (cena * 0.15);
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena < 400)
                    {
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                }
                else if (fruit == "Mango")
                {
                    cena = 5 * 19.60 * n;
                    if (cena > 1000)
                    {
                        cena = cena / 2;
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena >= 400 && cena <= 1000)
                    {
                        cena = cena - (cena * 0.15);
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena < 400)
                    {
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                }
                else if (fruit == "Pineapple")
                {
                    cena = 5 * 24.80 * n;
                    if (cena > 1000)
                    {
                        cena = cena / 2;
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena >= 400 && cena <= 1000)
                    {
                        cena = cena - (cena * 0.15);
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena < 400)
                    {
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                }
                else if (fruit == "Mango")
                {
                    cena = 5 * 15.20 * n;
                    if (cena > 1000)
                    {
                        cena = cena / 2;
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena >= 400 && cena <= 1000)
                    {
                        cena = cena - (cena * 0.15);
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                    else if (cena < 400)
                    {
                        Console.WriteLine("{0:F2} lv.", cena);
                    }
                }
            }
        }
    }
}
