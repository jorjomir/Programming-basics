using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace po_malkoto_chislo
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = int.MaxValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                if (min > m)
                {
                    min = m;
                }
            }
            Console.WriteLine(min);
        }
    }
}
