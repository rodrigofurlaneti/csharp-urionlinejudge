using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {
            int dias = Convert.ToInt32(Console.ReadLine());
            int ano = 0;
            while (dias >= 365)
            {
                ano++;
                dias = dias - 365;
            }
            int mes = 0;
            while (dias >= 30)
            {
                mes++;
                dias = dias - 30;
            }
            Console.WriteLine("{0} ano(s)", ano);
            Console.WriteLine("{0} mes(es)", mes);
            Console.WriteLine("{0} dia(s)", dias);
            Console.ReadKey();
        }
    }
}