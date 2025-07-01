using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string word;

            int lastTwo = n % 100;
            int lastOne = n % 10;

            if (lastTwo >= 11 && lastTwo <= 14)
                word = "домов";
            else if (lastOne == 1)
                word = "дом";
            else if (lastOne >= 2 && lastOne <= 4)
                word = "дома";
            else
                word = "домов";

            Console.WriteLine($"Мы построили {n} {word}");
            Console.ReadKey();
        }
    }
}