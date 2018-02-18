using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faktoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int fakt = 1;
            do
            {
                fakt = fakt * n;
                n--;
            } while (n>1);
            Console.WriteLine(fakt);
        }
    }
}
