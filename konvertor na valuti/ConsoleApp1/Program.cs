using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var money = double.Parse(Console.ReadLine());
            string current = Console.ReadLine();
            string wanted = Console.ReadLine();
            bool result = false;
            if (current == "USD")
            {
                money = money * 1.79549;
            }
            else if (current == "EUR") 
            {
                money = money * 1.95583;
            }
            else if (current == "GBP")
            {
                money = money * 2.53405;
            }
            if (wanted=="USD")
            {
                money = money / 1.79549;
            }
            else if(wanted=="EUR")
            {
                money = money / 1.95583;
            }
            else if(wanted=="GBP")
            {
                money = money / 2.53405;
            }
            Console.WriteLine("{0} {1}",Math.Round(money,2),wanted);
        }

    }
}
