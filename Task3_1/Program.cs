using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());

            if (a > b)
                Console.WriteLine(">");
            else if (a < b)
                Console.WriteLine("<");
            else
                Console.WriteLine("=");

            Console.ReadKey();
        }
    }
}
