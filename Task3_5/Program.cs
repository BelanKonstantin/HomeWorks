using System;

namespace Task3_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input) && input[input.Length - 1] == '0')
                Console.WriteLine("Да");
            else
                Console.WriteLine("Нет");

            Console.ReadKey();
        }
    }
}