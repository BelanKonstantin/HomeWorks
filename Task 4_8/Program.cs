using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int sign = n < 0 ? -1 : 1;
            n = Math.Abs(n);

            int reversed = 0;
            while (n > 0)
            {
                reversed = reversed * 10 + n % 10;
                n /= 10;
            }

            Console.WriteLine(sign * reversed);
            Console.ReadKey();
        }
    }
}
