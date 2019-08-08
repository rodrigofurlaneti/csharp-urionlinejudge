using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            NumberFormatInfo n = new CultureInfo("en-US").NumberFormat;
            String linha1 = Console.ReadLine();
            String linha2 = Console.ReadLine();
            String[] valores1 = linha1.Split(' ');
            int codPeca1 = Convert.ToInt32(valores1[0]);
            int numPecas1 = Convert.ToInt32(valores1[1]);
            decimal valorPeca1 = Convert.ToDecimal(valores1[2], n);
            String[] valores2 = linha2.Split(' ');
            int codPeca2 = Convert.ToInt32(valores2[0]);
            int numPecas2 = Convert.ToInt32(valores2[1]);
            decimal valorPeca2 = Convert.ToDecimal(valores2[2], n);
            decimal res = ((numPecas1 * valorPeca1) + (numPecas2 * valorPeca2));
            Console.WriteLine("VALOR A PAGAR: R$ {0}", res.ToString("F2", CultureInfo.InvariantCulture));
            Console.ReadLine();
        }
    }
}