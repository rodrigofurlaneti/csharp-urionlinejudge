using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consumo
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo n = new CultureInfo("en-US").NumberFormat;
            int valor1 = Convert.ToInt32(Console.ReadLine());
            double valor2 = Convert.ToDouble(Console.ReadLine(), n);
            double res = valor1 / valor2;
            Console.WriteLine("{0} km/l", res.ToString("N3"), n);
        }
    }
}