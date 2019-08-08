using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TesteDeSelecao1
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
            int d = Convert.ToInt32(valores1[3]);
            if ((b > c) && (d > a))
            {
                if ((c + d) > (a + b))
                {
                    Console.WriteLine("Valores aceitos");
                }
                else
                {
                    Console.WriteLine("Valores nao aceitos");
                }
            }
            else
            {
                Console.WriteLine("Valores nao aceitos");
            }
            Console.ReadKey();
        }
    }
}