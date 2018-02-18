using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personal_Titles
{
    class Program
    {
        static void Main(string[] args)
        {
            var age = double.Parse(Console.ReadLine());
            var sex = char.Parse(Console.ReadLine());
            if (age < 16)
            {
                if (sex=='m')
                {
                    Console.WriteLine("Master");
                }
                else if (sex == 'f') { Console.WriteLine("Miss"); }
            }
            else
            {
                if(sex=='m')
                {
                    Console.WriteLine("Mr.");
                }
                if(sex=='f')
                {
                    Console.WriteLine("Ms.");
                }
            }

        }
    }
}
