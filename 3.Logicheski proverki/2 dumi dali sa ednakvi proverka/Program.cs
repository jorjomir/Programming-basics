using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_dumi_dali_sa_ednakvi_proverka
{
    class Program
    {
        static void Main(string[] args)
        {
            var duma1 = Console.ReadLine().ToLower();
            var duma2 = Console.ReadLine().ToLower();
            if (duma1 == duma2)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
