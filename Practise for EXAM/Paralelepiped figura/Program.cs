using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paralelepiped_figura
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string firstrow = $"+{new string('~', n - 2)}+{new string('.', 2 * n + 1)}";
            Console.WriteLine(firstrow);
            int leftdotscount = 0;
            int rightdotscount = 2*n;
            for (int i = 0; i < 2*n+1; i++)
            {
                Console.Write($"|{new string('.',leftdotscount)}");
                Console.Write($"\\{new string('~',n-2)}\\");
                Console.WriteLine(new string('.',rightdotscount));
                leftdotscount++;
                rightdotscount--;
            }
            leftdotscount = 0;
            rightdotscount = 2 * n;
            for (int i = 0; i < 2*n+1; i++)
            {
                Console.Write(new string('.',leftdotscount));
                Console.Write("\\");
                Console.Write(new string('.',rightdotscount));
                Console.WriteLine($"|{new string('~',n-2)}|");
                leftdotscount++;
                rightdotscount--;
            }
            string lastrow = $"{new string('.', 2 * n + 1)}+{new string('~', n - 2)}+";
            Console.WriteLine(lastrow);
        }
    }
}
