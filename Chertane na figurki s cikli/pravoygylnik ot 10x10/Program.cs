using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pravoygylnik_ot_10x10
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                for (int r = 0; r < n; r++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
