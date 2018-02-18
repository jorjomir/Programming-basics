using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chetna_ili_Nechetna_suma
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int chetno = 0;
            int nechetno = 0;
            for (int i = 0; i < n; i++)
            {
                int m = int.Parse(Console.ReadLine());
                if (i % 2 == 0)
                {
                    chetno += m;
                }
                else
                {
                    nechetno += m;
                }

            }
            if (chetno==nechetno)
            {
                Console.WriteLine("Yes Sum = "+chetno);
            }
            else
            {
                Console.WriteLine("No Diff = " + Math.Abs(chetno - nechetno));
            }
        }
    }
}
