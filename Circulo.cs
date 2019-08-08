using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Circulo
{
    class Program
    {
        static void Main(string[] args)
        {
            double r;
            r = Convert.ToDouble(Console.ReadLine());
            double A = 3.14159 * r * r;
            Console.WriteLine("A={0:0.0000}", A);
            Console.ReadLine();
        }
    }
}