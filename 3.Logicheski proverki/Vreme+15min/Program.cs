using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vreme_15min
{
    class Program
    {
        static void Main(string[] args)
        {
            int chas = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());
            int rdy= min + 15;
            if (rdy > 59)
            {
                chas++;
                rdy -= 60;
            }
            if (chas > 23)
            {
                chas -= 24;
            }
            Console.WriteLine("{0}:{1:00}", chas,rdy);
        }
    }
}
