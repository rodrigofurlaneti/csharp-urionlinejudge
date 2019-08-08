using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormulaDeBhaskara
{
    class Program
    {
        static void Main(string[] args)
        {

            NumberFormatInfo n = new CultureInfo("en-US").NumberFormat;
            String linha1 = Console.ReadLine();
            String[] valores1 = linha1.Split(' ');
            double a = Convert.ToDouble(valores1[0], n);
            double b = Convert.ToDouble(valores1[1], n);
            double c = Convert.ToDouble(valores1[2], n);
            if (a != 0)
            {
                double delta = (b * b) - (4 * a * c);
                double raiz = Math.Sqrt(delta);
                bool teste = Double.IsNaN(raiz);
                if (teste != true)
                {
                    double x1 = ((-(b)) + raiz) / (2 * a);
                    double x2 = ((-(b)) - raiz) / (2 * a);
                    Console.WriteLine("R1 = {0}", x1.ToString("F5", CultureInfo.InvariantCulture));
                    Console.WriteLine("R2 = {0}", x2.ToString("F5", CultureInfo.InvariantCulture));
                }
                else
                {
                    Console.WriteLine("Impossivel calcular");
                }
            }
            else
            {
                Console.WriteLine("Impossivel calcular");
            }
            Console.ReadLine();
        }
    }
}
