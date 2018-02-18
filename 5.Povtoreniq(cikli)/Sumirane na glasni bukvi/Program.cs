using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sumirane_na_glasni_bukvi
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int suma = 0;
            for (int i = 0; i < text.Length; i++)
            {
                char simvol = text[i];
                
                if (simvol=='a')
                {
                    suma += 1;
                }
                else if (simvol=='e')
                {
                    suma += 2;
                }
                else if(simvol=='i')
                {
                    suma += 3;
                }
                else if (simvol=='o')
                {
                    suma += 4;
                }
                else if (simvol=='u')
                {
                    suma += 5;
                }
            }
            Console.WriteLine(suma);
        }
    }
}
