using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Input Lenght in inch: ");
            double l_i = Convert.ToDouble(Console.ReadLine());
            double l_cm = l_i * 2.54;
            int l_m = (int)(l_cm /100);
            int l_sm = (int)(l_cm * 100 /100);
            double l_mm = l_cm * 10;
            double l_mm_2 = l_mm-l_sm * 10;


/* Console.WriteLine("Length in cm is: {0} ",l_cm);
Console.WriteLine("Length in mm is: {0} ", l_mm);*/
            Console.WriteLine("Length im m, cm, mm is: {0} m {1} cm {2} mm", l_m, l_sm, l_mm_2);

            Console.ReadKey();
        }
    }
}
