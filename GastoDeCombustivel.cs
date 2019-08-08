using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GastoDeCombustivel
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo n = new CultureInfo("en-US").NumberFormat;
            decimal valor1 = Convert.ToDecimal(Console.ReadLine());
            decimal valor2 = Convert.ToDecimal(Console.ReadLine());
            decimal res = (valor2 / 12) * valor1;
            Console.WriteLine("{0}", res.ToString("N3"), n);
            Console.ReadLine();
        }
    }
}