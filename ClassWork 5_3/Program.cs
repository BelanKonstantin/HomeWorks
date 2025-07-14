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

            for (int i=0; i<n-1; i++) 
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (t[i] > t[j])
                    {
                        int temp = t[i];
                        t[i] = t[j];
                        t[j] = temp;
                    }
                }

            }
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("{0} ", t[i]);
            }
         
            Console.ReadKey();
        }

    }

}
