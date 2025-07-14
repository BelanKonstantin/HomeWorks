using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            n = Math.Abs(n);

            int count = 1;
            int temp = n;
            while (temp >= 10)
            {
                temp /= 10;
                count++;
            }

            Console.WriteLine($"Количество цифр: {count}");
            Console.ReadKey();
        }
    }
}
