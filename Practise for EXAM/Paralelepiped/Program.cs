using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralelepiped
{
    class Program
    {
        static void Main(string[] args)
        {
            double Jelev = 0;
            double RoYaL = 0;
            double Roli = 0;
            double Trofon = 0;
            double Sino = 0;
            double others = 0;
            int n = int.Parse(Console.ReadLine());
            double pari = double.Parse(Console.ReadLine());
            double lekciq = pari / n;
            for (int i = 0; i < n; i++)
            {
                string lektori = Console.ReadLine();
                if (lektori=="Jelev")
                {
                    Jelev += lekciq;
                }
                else if (lektori=="RoYaL")
                {
                    RoYaL += lekciq;
                }
                else if (lektori=="Roli")
                {
                    Roli += lekciq;
                }
                else if (lektori=="Trofon")
                {
                    Trofon += lekciq;
                }
                else if (lektori=="Sino")
                {
                    Sino += lekciq;
                }
                else
                {
                    others += lekciq;
                }
            }
            Console.WriteLine("Jelev salary: {0:F2} lv",Jelev);
            Console.WriteLine("RoYaL salary: {0:F2} lv", RoYaL);
            Console.WriteLine("Roli salary: {0:F2} lv", Roli);
            Console.WriteLine("Trofon salary: {0:F2} lv", Trofon);
            Console.WriteLine("Sino salary: {0:F2} lv", Sino);
            Console.WriteLine("Others salary: {0:F2} lv", others);
        }
    }
}
