using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5_10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 5;
            int[,] field = new int[n, n];
            Random rand = new Random();

            // Заполнение поля случайными 0 и 1
            for (int i = 0; i < n; i++)
                for (int j = 0; j < n; j++)
                    field[i, j] = rand.Next(0, 2);

            // Вывод поля
            Console.WriteLine("Клеточное поле:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    Console.Write(field[i, j] + " ");
                Console.WriteLine();
            }

            bool win = false;

            // Проверка горизонталей
            for (int i = 0; i < n; i++)
            {
                bool rowWin = true;
                for (int j = 0; j < n; j++)
                {
                    if (field[i, j] != 1)
                    {
                        rowWin = false;
                        break;
                    }
                }
                if (rowWin)
                {
                    win = true;
                    break;
                }
            }

            // Проверка вертикалей
            if (!win)
            {
                for (int j = 0; j < n; j++)
                {
                    bool colWin = true;
                    for (int i = 0; i < n; i++)
                    {
                        if (field[i, j] != 1)
                        {
                            colWin = false;
                            break;
                        }
                    }
                    if (colWin)
                    {
                        win = true;
                        break;
                    }
                }
            }

            // Проверка главной диагонали
            if (!win)
            {
                bool mainDiagWin = true;
                for (int i = 0; i < n; i++)
                {
                    if (field[i, i] != 1)
                    {
                        mainDiagWin = false;
                        break;
                    }
                }
                if (mainDiagWin)
                    win = true;
            }

            // Проверка побочной диагонали
            if (!win)
            {
                bool secDiagWin = true;
                for (int i = 0; i < n; i++)
                {
                    if (field[i, n - 1 - i] != 1)
                    {
                        secDiagWin = false;
                        break;
                    }
                }
                if (secDiagWin)
                    win = true;
            }

            Console.WriteLine(win ? "Крестики выиграли!" : "Крестики не выиграли.");

            Console.ReadLine();
        }
    }
}
