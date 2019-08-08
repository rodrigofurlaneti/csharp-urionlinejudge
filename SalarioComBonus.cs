using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SalarioComBonus
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo n = new CultureInfo("en-US").NumberFormat;
            string a = Console.ReadLine();
            decimal b = Convert.ToDecimal(Console.ReadLine(), n);
            decimal c = Convert.ToDecimal(Console.ReadLine(), n);
            decimal res = (((c / 100) * 15) + b);
            Console.WriteLine("TOTAL = R$ {0}", res.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadKey();
        }
    }
}