using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mesechni_razhodi
{
    class Program
    {
        static void Main(string[] args)
        {
            double mesechentok = 0;
            double tok = 0;
            double voda = 0;
            double internet = 0;
            double drugi = 0;
            double average = 0;
            int broimeseci = int.Parse(Console.ReadLine());
            for (int i = 0; i < broimeseci; i++)
            {
                mesechentok = double.Parse(Console.ReadLine());
                tok+=mesechentok;
                voda += 20;
                internet += 15;
                drugi += (mesechentok + 20 + 15) * 1.2;
            }
            average = (tok + voda + internet + drugi) / broimeseci;
            Console.WriteLine("Electricity: {0:F2} lv",tok);
            Console.WriteLine("Water: {0:F2} lv", voda);
            Console.WriteLine("Internet: {0:F2} lv", internet);
            Console.WriteLine("Other: {0:F2} lv", drugi);
            Console.WriteLine("Average: {0:F2} lv", average);

        }
    }
}
