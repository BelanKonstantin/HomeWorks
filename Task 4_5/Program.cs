using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.Write("Введите число из диапазона [20; 60]: ");
                number = Convert.ToInt32(Console.ReadLine());
            }
            while (number < 20 || number > 60);

            Console.WriteLine($"Вы ввели корректное число: {number}");
            Console.ReadKey();
        }
    }
}
