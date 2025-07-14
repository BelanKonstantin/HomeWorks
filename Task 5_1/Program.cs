using System;

namespace Task_5_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            Random rnd = new Random();
            int evenCount = 0, oddCount = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rnd.Next(0, 101);
                if (arr[i] % 2 == 0)
                    evenCount++;
                else
                    oddCount++;
            }

            Console.WriteLine("Массив: " + string.Join(", ", arr));
            if (evenCount > oddCount)
                Console.WriteLine("Четных чисел больше.");
            else if (oddCount > evenCount)
                Console.WriteLine("Нечетных чисел больше.");
            else
                Console.WriteLine("Четных и нечетных чисел поровну.");

            Console.ReadKey();
        }
    }
}
