using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double number = Convert.ToDouble(Console.ReadLine());
            if (number <= -10 || number >= 10)
                Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");

            Console.ReadKey();
        }
    }
}