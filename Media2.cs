using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media2
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo n = new CultureInfo("en-US").NumberFormat;
            double a = Convert.ToDouble(Console.ReadLine(), n);
            double b = Convert.ToDouble(Console.ReadLine(), n);
            double c = Convert.ToDouble(Console.ReadLine(), n);
            double media = (((a * 2) + (b * 3) + (c * 5)) / 10);
            Console.WriteLine("MEDIA = {0}", media.ToString("0.0"));
            Console.ReadKey();
        }
    }
}