using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3_12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            if (!int.TryParse(Console.ReadLine(), out number) || number < 100 || number > 999)
            {
                Console.WriteLine("Ошибка: введите целое число от 100 до 999.");
                Console.ReadKey();
                return;
            }

            string[] hundreds = { "", "сто", "двести", "триста", "четыреста", "пятьсот", "шестьсот", "семьсот", "восемьсот", "девятьсот" };
            string[] tens = { "", "десять", "двадцать", "тридцать", "сорок", "пятьдесят", "шестьдесят", "семьдесят", "восемьдесят", "девяносто" };
            string[] teens = { "десять", "одиннадцать", "двенадцать", "тринадцать", "четырнадцать", "пятнадцать", "шестнадцать", "семнадцать", "восемнадцать", "девятнадцать" };
            string[] units = { "", "один", "два", "три", "четыре", "пять", "шесть", "семь", "восемь", "девять" };

            int h = number / 100;
            int t = (number / 10) % 10;
            int u = number % 10;

            string result = hundreds[h];

            if (t == 1)
            {
                result += " " + teens[u];
            }
            else
            {
                if (t > 0)
                    result += " " + tens[t];
                if (u > 0)
                    result += " " + units[u];
            }

            Console.WriteLine(result.Trim());
            Console.ReadKey();
        }
    }
}