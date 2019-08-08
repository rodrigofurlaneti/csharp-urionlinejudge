using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Esfera
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo n = new CultureInfo("en-US").NumberFormat;
            int valor1 = Convert.ToInt32(Console.ReadLine());
            double pi = 3.14159;
            double valor2 = Math.Pow(valor1, 3);
            double res = ((4 * pi * valor2) / 3);
            Console.WriteLine("VOLUME = {0}", res.ToString("F3", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}