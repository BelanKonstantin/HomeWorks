using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_2
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

            double sum = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += 1.0 / i;
            }

            Console.WriteLine($"Сумма: {sum}");
            Console.ReadKey();
        }
    }
}
