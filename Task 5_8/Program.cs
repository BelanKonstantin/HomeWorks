using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[5];
            Random rand = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(0, 11); // [0, 10]
            }

            Console.WriteLine("Массив: " + string.Join(", ", array));

            // Поиск двух наибольших элементов
            int firstMax = array[0];
            int secondMax = array[0];

            // Найти первый максимум
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] > firstMax)
                    firstMax = array[i];
            }

            // Найти второй максимум (включая повторяющиеся максимумы)
            bool foundFirst = false;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == firstMax && !foundFirst)
                {
                    foundFirst = true;
                    continue;
                }
                if (array[i] > secondMax && array[i] <= firstMax)
                    secondMax = array[i];
            }

            // Если все элементы равны, второй максимум равен первому
            if (!array.Any(x => x < firstMax))
                secondMax = firstMax;

            Console.WriteLine($"Два наибольших числа: {firstMax} и {secondMax}");

            Console.ReadLine();
        }
    }
}
