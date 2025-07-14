using System;

namespace Task_5_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 10;
            int cols = 5;
            int[,] array = new int[rows, cols];
            Random rand = new Random();

            // Заполнение массива случайными числами [0, 10]
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = rand.Next(0, 11);
                }
            }

            // Вывод массива
            Console.WriteLine("Двумерный массив:");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            // Определение максимального элемента в каждой строке
            Console.WriteLine("\nМаксимальные элементы по строкам:");
            for (int i = 0; i < rows; i++)
            {
                int max = array[i, 0];
                for (int j = 1; j < cols; j++)
                {
                    if (array[i, j] > max)
                        max = array[i, j];
                }
                Console.WriteLine($"Строка {i + 1}: {max}");
            }

            Console.ReadLine();
        }
    }
}
