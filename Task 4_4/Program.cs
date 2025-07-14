using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            if (a <= 0 || b >= 0)
            {
                Console.WriteLine("Ошибка: a должно быть больше 0, b должно быть меньше 0.");
                Console.ReadKey();
                return;
            }

            double result = 1.0;
            int exp = -b;
            for (int i = 0; i < exp; i++)
            {
                result *= a;
            }
            result = 1.0 / result;

            Console.WriteLine($"{a}^{b} = {result}");
            Console.ReadKey();
        }
    }
}
