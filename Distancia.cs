using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Distancia
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = Convert.ToInt32(Console.ReadLine());
            int res = (valor1 * 60) / 30;
            Console.WriteLine("{0} minutos", res);
            Console.ReadLine();
        }
    }
}