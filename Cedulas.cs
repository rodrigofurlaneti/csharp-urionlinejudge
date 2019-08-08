using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = Convert.ToInt32(Console.ReadLine());
            int valor2 = valor1;
            int c100 = 0;
            while (valor1 >= 100)
            {
                c100++;
                valor1 = valor1 - 100;
            }
            int c50 = 0;
            while (valor1 >= 50)
            {
                c50++;
                valor1 = valor1 - 50;
            }
            int c20 = 0;
            while (valor1 >= 20)
            {
                c20++;
                valor1 = valor1 - 20;
            }
            int c10 = 0;
            while (valor1 >= 10)
            {
                c10++;
                valor1 = valor1 - 10;
            }
            int c5 = 0;
            while (valor1 >= 5)
            {
                c5++;
                valor1 = valor1 - 5;
            }
            int c2 = 0;
            while (valor1 >= 2)
            {
                c2++;
                valor1 = valor1 - 2;
            }
            int c1 = 0;
            while (valor1 >= 1)
            {
                c1++;
                valor1 = valor1 - 1;
            }
            Console.WriteLine("{0}", valor2);
            Console.WriteLine("{0} nota(s) de R$ 100,00", c100);
            Console.WriteLine("{0} nota(s) de R$ 50,00", c50);
            Console.WriteLine("{0} nota(s) de R$ 20,00", c20);
            Console.WriteLine("{0} nota(s) de R$ 10,00", c10);
            Console.WriteLine("{0} nota(s) de R$ 5,00", c5);
            Console.WriteLine("{0} nota(s) de R$ 2,00", c2);
            Console.WriteLine("{0} nota(s) de R$ 1,00", c1);
            Console.ReadLine();
        }
    }
}