using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Task2_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input grad: ");
            int grad = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input minutes: ");
            int min = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Input seconds: ");
            int sec = Convert.ToInt32(Console.ReadLine());

            double min_in_grad = min/ 60.0;
            double sec_in_grad = sec/3600.0;
            
            double a_grad= grad + min_in_grad + sec_in_grad;

            double radians = a_grad * Math.PI / 180;
            Console.WriteLine($"Angle in radians: {radians:F6}");
            Console.ReadKey();
        }
    }
}
