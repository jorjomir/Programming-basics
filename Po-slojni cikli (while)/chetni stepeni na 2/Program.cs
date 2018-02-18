using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chetni_stepeni_na_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("1");
            int num = 1;
            for (int i = 1; i < n; i+=2)
            {
                num = num * 2 * 2;
                Console.WriteLine(num);
            }
        }
    }
}
