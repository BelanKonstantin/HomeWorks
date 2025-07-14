using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace ClassWork_6_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            string str = Console.ReadLine();
            while (str.Contains("  "))
            {
                str = str.Replace("  ", " ");
            }
            str = str.Trim();
            Console.WriteLine(str);
            Console.ReadKey();
        }
    }
}
