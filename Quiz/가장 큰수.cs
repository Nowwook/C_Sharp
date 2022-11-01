using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Q12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] c = new int[7] { 61, 2, 9, 3, 4, 8, 5 };
            int max = Int32.MinValue;
            for (int i = 0; i < 7; i++)
            {
                if (c[i] > max)
                {
                    max = c[i];
                }
            }
            Console.WriteLine(max);
            

            string a = Console.ReadLine();
            string[] b = a.Split(' ');
            int m = Int32.Parse(b[0]);
            for (int i = 1; i < 7; i++)
            {
                if (Int32.Parse(b[i]) > m)
                {
                    m = Int32.Parse(b[i]);
                }
            }
            Console.WriteLine(m);
        }
    }
}
