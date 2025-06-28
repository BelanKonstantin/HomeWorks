using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWork3_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            int absoluteValue = 0;
            if (number > 0)
            {
                absoluteValue = number;
            }
            else
            {
                absoluteValue = -number;
            }
            Console.WriteLine("Absolute value: " + absoluteValue);
        }
    }
}
