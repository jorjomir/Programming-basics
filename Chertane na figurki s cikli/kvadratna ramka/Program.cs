using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace kvadratna_ramka
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Console.Write("+ ");
            for (int i = 1; i <= n-2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
            for (int j=1; j<=n-2;j++)
            {
                Console.Write("| ");
                for (int r = 1; r <= n - 2; r++)
                {
                    Console.Write("- ");
                }
                Console.WriteLine("|");
            }
            Console.Write("+ ");
            for (int i = 1; i <= n - 2; i++)
            {
                Console.Write("- ");
            }
            Console.WriteLine("+");
        }
    }
}
