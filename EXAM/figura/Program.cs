using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace figura
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            //First row
            string firstrow = $"{new string('#', n*4 + 1)}";
            Console.WriteLine(firstrow);
            //dots
            int zvezdichki = 2*n-1;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(".");
                }
                Console.WriteLine(".");
                
            }
        }
    }
}
