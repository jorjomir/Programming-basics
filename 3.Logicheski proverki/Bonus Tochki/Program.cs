using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bonus_Tochki
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter score: ");
            int score = int.Parse(Console.ReadLine());
            var bonusscore = 0.0;
            if (score>1000)
            {
                bonusscore =score*0.1;
            }
            else if(score<1000)
            {
                bonusscore = score * 0.2;
            }
            else if(score<=100)
            {
                bonusscore = 5;
            }
            if (score%10==5)
            {
                bonusscore = bonusscore + 2;
            }
            if (score%2==0)
            {
                bonusscore = bonusscore + 1;
            }
            Console.WriteLine("Bonus score: {0}",bonusscore);
            Console.WriteLine("Total score: {0}", score+bonusscore);
        }
    }
}
