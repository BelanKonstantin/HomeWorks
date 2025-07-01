using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            if ((number >= 10 && number <= 99) || (number <= -10 && number >= -99))
                Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");

            Console.ReadKey();
        }
    }
}