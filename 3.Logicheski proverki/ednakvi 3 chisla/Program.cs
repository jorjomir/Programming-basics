﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ednakvi_3_chisla
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());
            if (a == b)
            {
                if (a == c)
                {
                    Console.WriteLine("yes");
                }
            }
            else
            {
                Console.WriteLine("no");
            }
        }
    }
}
