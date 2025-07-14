using System;
using System.Linq;

namespace Task_5_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[10];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(-50, 51); // [-50, 50]
            }

            Console.WriteLine("Исходный массив: " + string.Join(", ", array));

            // Сортировка первых 5 элементов по возрастанию
            int[] firstHalf = array.Take(5).ToArray();
            Array.Sort(firstHalf);

            // Сортировка вторых 5 элементов по убыванию
            int[] secondHalf = array.Skip(5).Take(5).ToArray();
            Array.Sort(secondHalf);
            Array.Reverse(secondHalf);

            // Объединение двух частей
            int[] sortedArray = firstHalf.Concat(secondHalf).ToArray();

            Console.WriteLine("Отсортированный массив: " + string.Join(", ", sortedArray));

            Console.ReadLine();
        }
    }
}
