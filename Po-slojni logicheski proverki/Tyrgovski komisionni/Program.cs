using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tyrgovski_komisionni
{
    class Program
    {
        static void Main(string[] args)
        {
            double komisionna = -1;
            string grad = Console.ReadLine().ToLower();
            double prodajbi = double.Parse(Console.ReadLine());
            if (grad=="sofia")
            {
                if(prodajbi>=0 && prodajbi<=500)
                {
                    komisionna = 0.05;
                    Console.WriteLine("{0:f2}",komisionna*prodajbi);
                }
                else if (prodajbi >= 500 && prodajbi <= 1000)
                {
                    komisionna = 0.07;
                    Console.WriteLine("{0:f2}", komisionna * prodajbi);
                }
                else if (prodajbi >= 1000 && prodajbi <= 10000)
                {
                    komisionna = 0.08;
                    Console.WriteLine("{0:f2}", komisionna * prodajbi);
                }
                else if (prodajbi >10000)
                {
                    komisionna = 0.12;
                    Console.WriteLine("{0:f2}", komisionna * prodajbi);
                }
            }
            else if (grad == "varna")
            {
                if (prodajbi >= 0 && prodajbi <= 500)
                {
                    komisionna = 0.045;
                    Console.WriteLine("{0:f2}", komisionna * prodajbi);
                }
                else if (prodajbi >= 500 && prodajbi <= 1000)
                {
                    komisionna = 0.075;
                    Console.WriteLine("{0:f2}", komisionna * prodajbi);
                }
                else if (prodajbi >= 1000 && prodajbi <= 10000)
                {
                    komisionna = 0.1;
                    Console.WriteLine("{0:f2}", komisionna * prodajbi);
                }
                else if (prodajbi > 10000)
                {
                    komisionna = 0.13;
                    Console.WriteLine("{0:f2}", komisionna * prodajbi);
                }
            }
            if (grad == "plovdiv")
            {
                if (prodajbi >= 0 && prodajbi <= 500)
                {
                    komisionna = 0.055;
                    Console.WriteLine("{0:f2}", komisionna * prodajbi);
                }
                else if (prodajbi >= 500 && prodajbi <= 1000)
                {
                    komisionna = 0.08;
                    Console.WriteLine("{0:f2}", komisionna * prodajbi);
                }
                else if (prodajbi >= 1000 && prodajbi <= 10000)
                {
                    komisionna = 0.12;
                    Console.WriteLine("{0:f2}", komisionna * prodajbi);
                }
                else if (prodajbi > 10000)
                {
                    komisionna = 0.145;
                    Console.WriteLine("{0:f2}", komisionna * prodajbi);
                }
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
