using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double d = Convert.ToDouble(Console.ReadLine());

            double max = a;
            if (b > max) max = b;
            if (c > max) max = c;
            if (d > max) max = d;

            Console.WriteLine("Max: " + max);
            Console.ReadKey();
        }
    }
}
