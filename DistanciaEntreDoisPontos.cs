using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanciaEntreDoisPontos
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo n = new CultureInfo("en-US").NumberFormat;
            String linha1 = Console.ReadLine();
            String[] valores1 = linha1.Split(' ');
            decimal a = Convert.ToDecimal(valores1[0], n);
            decimal b = Convert.ToDecimal(valores1[1], n);
            String linha2 = Console.ReadLine();
            String[] valores2 = linha2.Split(' ');
            decimal c = Convert.ToDecimal(valores2[0], n);
            decimal d = Convert.ToDecimal(valores2[1], n);
            decimal l1 = Convert.ToDecimal(Math.Pow(Convert.ToDouble(a - c), 2));
            decimal l2 = Convert.ToDecimal(Math.Pow(Convert.ToDouble(b - d), 2));
            double l3 = Convert.ToDouble(l1) + Convert.ToDouble(l2);
            double res = Math.Sqrt(l3);
            Console.WriteLine("{0}", res.ToString("F4", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}