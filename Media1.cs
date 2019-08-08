using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Media1
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo n = new CultureInfo("en-US").NumberFormat;
            double a = Convert.ToDouble(Console.ReadLine(), n);
            double b = Convert.ToDouble(Console.ReadLine(), n);
            double media = (((3.5 * a) + (7.5 * b)) / 11);
            Console.WriteLine("MEDIA = {0}", media.ToString("0.00000"));
            Console.ReadKey();

        }
    }
}