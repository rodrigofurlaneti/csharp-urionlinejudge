using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NotasMoedas
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo n = new CultureInfo("en-US").NumberFormat;
            decimal valor1 = Convert.ToDecimal(Console.ReadLine(), n);
            decimal c100 = 0;
            while (valor1 >= Convert.ToDecimal(100.00, n))
            {
                c100++;
                valor1 = valor1 - Convert.ToDecimal(100.00, n);
            }
            decimal c50 = 0;
            while (valor1 >= Convert.ToDecimal(50.00, n))
            {
                c50++;
                valor1 = valor1 - Convert.ToDecimal(50.00, n);
            }
            decimal c20 = 0;
            while (valor1 >= Convert.ToDecimal(20.00, n))
            {
                c20++;
                valor1 = valor1 - Convert.ToDecimal(20.00, n);
            }
            decimal c10 = 0;
            while (valor1 >= Convert.ToDecimal(10.00, n))
            {
                c10++;
                valor1 = valor1 - Convert.ToDecimal(10.00, n);
            }
            decimal c5 = 0;
            while (valor1 >= Convert.ToDecimal(5.00, n))
            {
                c5++;
                valor1 = valor1 - Convert.ToDecimal(5.00, n);
            }
            decimal c2 = 0;
            while (valor1 >= Convert.ToDecimal(2.00, n))
            {
                c2++;
                valor1 = valor1 - Convert.ToDecimal(2.00, n);
            }
            decimal m1 = 0;
            while (valor1 >= Convert.ToDecimal(1.00, n))
            {
                m1++;
                valor1 = valor1 - Convert.ToDecimal(1.00, n);
            }
            decimal m50 = 0;
            while (valor1 >= Convert.ToDecimal(0.50, n))
            {
                m50++;
                valor1 = valor1 - Convert.ToDecimal(0.50, n);
            }
            decimal m25 = 0;
            while (valor1 >= Convert.ToDecimal(0.25, n))
            {
                m25++;
                valor1 = valor1 - Convert.ToDecimal(0.25, n);
            }
            decimal m10 = 0;
            while (valor1 >= Convert.ToDecimal(0.10, n))
            {
                m10++;
                valor1 = valor1 - Convert.ToDecimal(0.10, n);
            }
            decimal m05 = 0;
            while (valor1 >= Convert.ToDecimal(0.05, n))
            {
                m05++;
                valor1 = valor1 - Convert.ToDecimal(0.05, n);
            }
            decimal m01 = 0;
            while (valor1 >= Convert.ToDecimal(0.01, n))
            {
                m01++;
                valor1 = valor1 - Convert.ToDecimal(0.01, n);
            }
            Console.WriteLine("NOTAS:");
            Console.WriteLine("{0} nota(s) de R$ 100.00", c100);
            Console.WriteLine("{0} nota(s) de R$ 50.00", c50);
            Console.WriteLine("{0} nota(s) de R$ 20.00", c20);
            Console.WriteLine("{0} nota(s) de R$ 10.00", c10);
            Console.WriteLine("{0} nota(s) de R$ 5.00", c5);
            Console.WriteLine("{0} nota(s) de R$ 2.00", c2);
            Console.WriteLine("MOEDAS:");
            Console.WriteLine("{0} moeda(s) de R$ 1.00", m1);
            Console.WriteLine("{0} moeda(s) de R$ 0.50", m50);
            Console.WriteLine("{0} moeda(s) de R$ 0.25", m25);
            Console.WriteLine("{0} moeda(s) de R$ 0.10", m10);
            Console.WriteLine("{0} moeda(s) de R$ 0.05", m05);
            Console.WriteLine("{0} moeda(s) de R$ 0.01", m01);
            Console.ReadLine();
        }
    }
}