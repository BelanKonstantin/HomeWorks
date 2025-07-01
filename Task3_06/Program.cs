using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());

            double median;

            if ((a > b && a < c) || (a < b && a > c))
                median = a;
            else if ((b > a && b < c) || (b < a && b > c))
                median = b;
            else
                median = c;

            Console.WriteLine("Медиана: " + median);
            Console.ReadKey();
        }
    }
}
