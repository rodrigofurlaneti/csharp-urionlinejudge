using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutoSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            A = Convert.ToInt16(Console.ReadLine());
            B = Convert.ToInt16(Console.ReadLine());
            int PROD = A * B;
            Console.WriteLine("PROD = " + PROD);
            Console.ReadLine();
        }
    }
}