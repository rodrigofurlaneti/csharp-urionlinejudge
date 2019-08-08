using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SomaSimples
{
    class Program
    {
        static void Main(string[] args)
        {
            int A, B;
            A = Convert.ToInt16(Console.ReadLine());
            B = Convert.ToInt16(Console.ReadLine());
            int SOMA = (A + B);
            Console.WriteLine("SOMA = " + SOMA);
            Console.ReadLine();
        }
    }
}