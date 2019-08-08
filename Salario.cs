using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Salario
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo n = new CultureInfo("en-US").NumberFormat;
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine(), n);
            Console.WriteLine("NUMBER = {0}", a);
            Console.WriteLine("SALARY = U$ {0}", (b * c).ToString("000.00"));
            Console.ReadKey();
        }
    }
}