using System;

namespace Task_5_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 51); // [0, 50]
            }

            int maxValue = array[0];
            int minValue = array[0];
            int maxIndex = 0;
            int minIndex = 0;

            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > maxValue)
                {
                    maxValue = array[i];
                    maxIndex = i;
                }
                if (array[i] < minValue)
                {
                    minValue = array[i];
                    minIndex = i;
                }
            }

            Console.WriteLine("Массив: " + string.Join(", ", array));
            Console.WriteLine($"Максимальное значение: {maxValue}, индекс: {maxIndex}");
            Console.WriteLine($"Минимальное значение: {minValue}, индекс: {minIndex}");

            Console.ReadLine();
        }
    }
}
