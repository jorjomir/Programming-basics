using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sumirane_na_sekundi
{
    class Program
    {
        static void Main(string[] args)
        {
            int sec1 = int.Parse(Console.ReadLine());
            int sec2 = int.Parse(Console.ReadLine());
            int sec3 = int.Parse(Console.ReadLine());
            int sekundi = sec1 + sec2 + sec3;
            int mins = 0;
            if (sekundi < 59)
            {
                mins = 0;
            }

            else if (sekundi <= 119)
            {
                mins = 1;
                sekundi = sekundi - 60;
            }
            else if (sekundi > 119)
            {
                mins = 2;
                sekundi = sekundi - 120;
             
            }
            if (sekundi < 10)
            {
                Console.WriteLine(mins + ":" + "0" + sekundi);
            }
            else Console.WriteLine(mins + ":" + sekundi);
        }
    }
}
