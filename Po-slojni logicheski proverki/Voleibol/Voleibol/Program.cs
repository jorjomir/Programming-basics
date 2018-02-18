using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Voleibol
{
    class Program
    {
        static void Main(string[] args)
        {
            string godina = Console.ReadLine();
            int praznici = int.Parse(Console.ReadLine());
            int rodengrad = int.Parse(Console.ReadLine());
            if (godina == "normal")
            {
                double uikendivsofia = 48 - rodengrad;
                double broiigrivsofia = uikendivsofia * (3.0 / 4);
                double igrivpaznici = praznici * (2.0 / 3);
                double obshtbroi = broiigrivsofia + igrivpaznici;
                Console.WriteLine(Math.Floor(obshtbroi));
            }
            else if (godina=="leap")
            {
                double uikendivsofia = 48 - rodengrad;
                double broiigrivsofia = uikendivsofia * (3.0 / 4);
                double igrivpaznici = praznici * (2.0 / 3);
                double obshtbroi = broiigrivsofia + igrivpaznici;
                double visokosna = obshtbroi + obshtbroi * 0.15;
                Console.WriteLine(Math.Floor(visokosna));
            }
        }
    }
}
