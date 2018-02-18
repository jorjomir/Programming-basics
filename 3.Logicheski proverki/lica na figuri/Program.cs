using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lica_na_figuri
{
    class Program
    {
        static void Main(string[] args)
        {
            var figura = Console.ReadLine();
            if (figura == "square")
            {
                double a = double.Parse(Console.ReadLine());
                double s = a * a;
                Console.WriteLine("{0:0.###}", s);
            }
            else if (figura == "triangle")
            {
                double a = double.Parse(Console.ReadLine());
                double ha = double.Parse(Console.ReadLine());
                double s = a * ha / 2;
                Console.WriteLine("{0:0.###}", s);
            }
            else if (figura == "rectangle")
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                double s = a * b;
                Console.WriteLine("{0:0.###}", s);
            }
            else if (figura == "circle")
            {
                double a = double.Parse(Console.ReadLine());
                double s = Math.PI * a * a;
                Console.WriteLine("{0:0.###}", s);
            }
        }
    }
}
