using System;

namespace Task_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-20, 21); // [-20, 20]
            }

            int positiveCount = 0;
            int negativeCount = 0;
            int zeroCount = 0;

            foreach (int num in array)
            {
                if (num > 0)
                    positiveCount++;
                else if (num < 0)
                    negativeCount++;
                else
                    zeroCount++;
            }

            Console.WriteLine("Массив: " + string.Join(", ", array));
            Console.WriteLine($"Положительных: {positiveCount}");
            Console.WriteLine($"Отрицательных: {negativeCount}");
            Console.WriteLine($"Равных нулю: {zeroCount}");

            Console.ReadLine();
        }
    }
}
