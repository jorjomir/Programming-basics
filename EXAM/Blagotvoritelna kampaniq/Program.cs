using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blagotvoritelna_kampaniq
{
    class Program
    {
        static void Main(string[] args)
        {
            int dni = int.Parse(Console.ReadLine());
            int sladkari = int.Parse(Console.ReadLine());
            int torti = int.Parse(Console.ReadLine());
            int gofreti = int.Parse(Console.ReadLine());
            int palachinki = int.Parse(Console.ReadLine());
            double cena = 0;
            double torticena = torti * 45;
            double gofreticena = gofreti * 5.8;
            double palcena = palachinki * 3.20;
            double oneday = (torticena + gofreticena + palcena) * sladkari;
            cena = oneday * dni;
            cena = cena - (cena / 8);
            Console.WriteLine("{0:F2}",cena);
        }
    }
}
