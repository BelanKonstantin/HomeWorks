using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassWokr3_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a=Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());
            int max = (a > b) ? a : b;
            Console.WriteLine("Max: " + max);
            Console.ReadKey();
        }
    }
}
