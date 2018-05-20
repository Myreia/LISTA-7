using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬");
            Console.WriteLine("¬¬¬¬¬¬¬¬¬¬¬ Multiplos de 7 de 0 á 1000 ¬¬¬¬¬¬¬¬¬¬¬");
            Console.WriteLine("¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬¬");

            for (int i = 0; i <= 1000; i++)
            {
                if (i % 7 == 0)
                {
                    Console.WriteLine("\n\n" + i);
                }
            }

            Console.ReadKey();
        }
    }
}
