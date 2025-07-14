using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n <= 0)
            {
                Console.WriteLine("Нет");
                Console.ReadKey();
                return;
            }

            int value = 1;
            bool isPowerOfTwo = false;

            while (value <= n)
            {
                if (value == n)
                {
                    isPowerOfTwo = true;
                    break;
                }
                value *= 2;
            }

            Console.WriteLine(isPowerOfTwo ? "Да" : "Нет");
            Console.ReadKey();
        }
    }
}
