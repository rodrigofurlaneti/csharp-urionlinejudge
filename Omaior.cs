using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omaior
{
    class Program
    {
        static void Main(string[] args)
        {
            String linha1 = Console.ReadLine();
            String[] valores1 = linha1.Split(' ');
            int a = Convert.ToInt32(valores1[0]);
            int b = Convert.ToInt32(valores1[1]);
            int c = Convert.ToInt32(valores1[2]);
            if ((a > b) && (a > c))
            {
                Console.WriteLine("{0} eh o maior", a);
            }
            else if ((b > a) && (b > c))
            {
                Console.WriteLine("{0} eh o maior", b);
            }
            else
            {
                Console.WriteLine("{0} eh o maior", c);
            }
        }
    }
}