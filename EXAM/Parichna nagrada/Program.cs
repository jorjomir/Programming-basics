using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Parichna_nagrada
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double pari = double.Parse(Console.ReadLine());
            double cena = 0;
            double chetni = 0;
            double nechetni = 0;
            for (int i = 1; i <= n; i++)
            {
                double tochki = double.Parse(Console.ReadLine());
                if ((i%2)==0)
                {
                    chetni += tochki * 2;
                }
                else
                {
                    nechetni += tochki;
                }
            }
            cena = (chetni + nechetni) * pari;
            Console.WriteLine("The project prize was {0:F2} lv.",cena);
        }
    }
}
