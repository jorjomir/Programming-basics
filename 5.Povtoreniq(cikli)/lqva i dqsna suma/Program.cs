using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lqva_i_dqsna_suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int lqva = 0;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                lqva += m;
            }
            int dqsno = 0;
            for (int i = 0; i < n; i++)
            {
                int p = int.Parse(Console.ReadLine());
                dqsno += p;
            }
            if (lqva==dqsno)
            {
                Console.WriteLine("Yes, sum = {0}",lqva);
            }
            else
            {
                Console.WriteLine("No, diff = " + Math.Abs(lqva-dqsno));
            }
        } 
    }
}
