using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nai_golqmoto_chislo
{
    class Program
    {
        static void Main(string[] args)
        {

            int max=int.MinValue;
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                if(max<m)
                {
                    max = m;
                }
            }
            Console.WriteLine(max);
        }
    }
}
