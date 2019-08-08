using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
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
            decimal c = Convert.ToDecimal(valores1[2], n);
            decimal pi = Convert.ToDecimal(3.14159, n);
            decimal raio = Convert.ToDecimal(Math.Pow(Convert.ToDouble(c), 2), n);
            decimal triangulo = (a * c) / 2;
            decimal circulo = pi * raio;
            decimal trapezio = ((b + a) * c) / 2;
            decimal quadrado = Convert.ToDecimal(Math.Pow(Convert.ToDouble(b), 2), n);
            decimal retangulo = a * b;
            Console.WriteLine("TRIANGULO: {0}", triangulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("CIRCULO: {0}", circulo.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("TRAPEZIO: {0}", trapezio.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("QUADRADO: {0}", quadrado.ToString("F3", CultureInfo.InvariantCulture));
            Console.WriteLine("RETANGULO: {0}", retangulo.ToString("F3", CultureInfo.InvariantCulture));
        }
    }
}