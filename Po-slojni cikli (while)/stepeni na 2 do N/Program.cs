using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stepeni_na_2_do_N
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("1");
            int num = 1;
            for (int i = 0; i < n; i++)
            {
                num = (int)Math.Pow(2,i+1);
                Console.WriteLine(num);
            }
        }
    }
}
