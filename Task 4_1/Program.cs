using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            if (n < 1)
            {
                Console.WriteLine("Ошибка: введите натуральное число.");
                Console.ReadKey();
                return;
            }

            long factorial = 1;
            for (int i = 2; i <= n; i++)
            {
                factorial *= i;
            }

            Console.WriteLine($"{n}! = {factorial}");
            Console.ReadKey();
        }
    }
}
