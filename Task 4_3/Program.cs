using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a <= 0 || b <= 0)
            {
                Console.WriteLine("Ошибка: числа должны быть больше нуля.");
                Console.ReadKey();
                return;
            }

            int result = 1;
            for (int i = 0; i < b; i++)
            {
                result *= a;
            }

            Console.WriteLine($"{a}^{b} = {result}");
            Console.ReadKey();
        }
    }
}
