using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ввод размеров участка
            Console.Write("Введите размеры участка (a b): ");
            string[] landInput = Console.ReadLine().Split();
            int a = Convert.ToInt32(landInput[0]);
            int b = Convert.ToInt32(landInput[1]);

            // Ввод размеров первого дома
            Console.Write("Введите размеры первого дома (p q): ");
            string[] house1Input = Console.ReadLine().Split();
            int p = Convert.ToInt32(house1Input[0]);
            int q = Convert.ToInt32(house1Input[1]);

            // Ввод размеров второго дома
            Console.Write("Введите размеры второго дома (r s): ");
            string[] house2Input = Console.ReadLine().Split();
            int r = Convert.ToInt32(house2Input[0]);
            int s = Convert.ToInt32(house2Input[1]);

            bool canPlace =
                // Вариант 1: дома рядом по ширине
                ((p + r <= a) && (Math.Max(q, s) <= b)) ||
                ((p + r <= b) && (Math.Max(q, s) <= a)) ||
                // Вариант 2: дома рядом по длине
                ((q + s <= b) && (Math.Max(p, r) <= a)) ||
                ((q + s <= a) && (Math.Max(p, r) <= b));

            Console.WriteLine(canPlace ? "Да" : "Нет");
            Console.ReadKey();
        }
    }
}