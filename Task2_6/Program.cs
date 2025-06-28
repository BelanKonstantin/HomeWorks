using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Tube Length in m: ");
            double length = Convert.ToDouble(Console.ReadLine());
            double fraction = length - Math.Floor(length);
            double rounded = Math.Floor(length) + Math.Round(fraction * 2) / 2;

            Console.Write("Round Tube Length is: {0} m", rounded);

            Console.ReadKey();
        }
    }
}
