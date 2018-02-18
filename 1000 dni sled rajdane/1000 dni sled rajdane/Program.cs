using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1000_dni_sled_rajdane
{
    class Program
    {
        static void Main(string[] args)
        {
            var date = Console.ReadLine();
            var provider = System.Globalization.CultureInfo.InvariantCulture;
            var result = DateTime.ParseExact(date, "dd-MM-yyyy", provider);
            result = result.AddDays(999);
            Console.WriteLine(result.ToString("dd-MM-yyyy"));

        }
    }
}
