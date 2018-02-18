using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fruit_or_vegetable
{
    class Program
    {
        static void Main(string[] args)
        {
            string neshto = Console.ReadLine();
            if(neshto=="banana" || neshto=="kiwi" || neshto=="cherry" || neshto == "apple" || neshto == "lemon" || neshto == "grapes")
            {
                Console.WriteLine("fruit");
            }
            else if (neshto == "tomato" || neshto == "cucumber" || neshto == "pepper" || neshto == "carrot")
            {
                Console.WriteLine("vegetable");
            }
            else
            {
                Console.WriteLine("unknown");
            }
        }
    }
}
