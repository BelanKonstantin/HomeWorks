using System;

namespace Task_5_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 11); // [0, 10]
            }

            Console.WriteLine("Исходный массив: " + string.Join(", ", array));

            Array.Reverse(array);

            Console.WriteLine("Перевернутый массив: " + string.Join(", ", array));

            Console.ReadLine();
        }
    }
}
