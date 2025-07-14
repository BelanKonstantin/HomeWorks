   using System;

namespace Task_5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int rows = 5;
            int cols = 5;
            int[,] array = new int[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    array[i, j] = (i + j) % 2;
                }
            }

            // Вывод массива
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
