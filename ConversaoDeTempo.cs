using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversaoDeTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int segundos = Convert.ToInt32(Console.ReadLine());
            int hora = 0;
            while (segundos >= 3600)
            {
                hora++;
                segundos = segundos - 3600;
            }
            int minuto = 0;
            while (segundos >= 60)
            {
                minuto++;
                segundos = segundos - 60;
            }
            Console.WriteLine("{0}:{1}:{2}", hora, minuto, segundos);
            Console.ReadKey();
        }
    }
}


