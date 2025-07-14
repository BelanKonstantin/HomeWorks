using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                if (i == 5)
                    continue;
                Console.WriteLine("Квадрат числа {0} равен {1}", i, i * i);

            }
            Console.ReadKey();

        }
    }
}
