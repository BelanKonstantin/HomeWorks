using System;

namespace Task_5_9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int m = 10; // количество строк
            const int n = 10; // количество столбцов
            int[,] matrix = new int[m, n];

            int value = 1;
            int top = 0, bottom = m - 1, left = 0, right = n - 1;

            while (value <= m * n)
            {
                // Вверх -> вправо
                for (int j = left; j <= right && value <= m * n; j++)
                    matrix[top, j] = value++;

                top++;

                // Вправо -> вниз
                for (int i = top; i <= bottom && value <= m * n; i++)
                    matrix[i, right] = value++;

                right--;

                // Вниз -> влево
                for (int j = right; j >= left && value <= m * n; j--)
                    matrix[bottom, j] = value++;

                bottom--;

                // Влево -> вверх
                for (int i = bottom; i >= top && value <= m * n; i--)
                    matrix[i, left] = value++;

                left++;
            }

            // Вывод матрицы
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(matrix[i, j].ToString().PadLeft(3) + " ");
                }
                Console.WriteLine();
            }

            Console.ReadLine();
        }
    }
}
