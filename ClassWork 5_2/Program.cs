using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ClassWork_5_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const int n = 10;
            int[] t = new int[n];
            Random rnd = new Random();

            for (int i = 0; i < n; i++)
            {
                t[i] = rnd.Next(0, 11);
                Console.WriteLine("{0} ", t[i]);
            }
            Console.WriteLine();

            int max = t[0];
            foreach (var a in t)
            {
                if (a > max)
                {
                    max = a;

                }
            }
            Console.WriteLine("Max = {0}", max);
            Console.ReadKey();
        }
        
    }

}
