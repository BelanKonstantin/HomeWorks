using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input 3 Digits Number: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int a = n / 100;
            int b = (n / 10) % 10;
            int c = n % 10;


            int n2 = c * 100 + b * 10 + a;

            Console.Write("Reverse number is: ");
            Console.WriteLine(n2);

            Console.ReadKey();
        }
    }
}
