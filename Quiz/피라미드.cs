using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Q11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int N = Int32.Parse(Console.ReadLine());
            
            string a = "";
            for (int i = 0; i < N; i++)
            {
                a += "*";
                Console.WriteLine(a);
            }
            Console.WriteLine("-------------------");
            for (int j = 0; j < N; j++)
            {
                string b = "";
                for (int i = 0; i < N - j; i++)
                {
                    b += "*";                    
                }
                Console.WriteLine(b);
            }
            Console.WriteLine("-------------------");
            for (int i = 0; i < N; i++)
            {
                string c = "";
                for (int j = N-i; j >0; j--)
                {
                    c += " ";
                }
                c = c.Remove(0, 1);
                for (int j = 0; j <i+1; j++)
                {
                    c += "*";
                }
                Console.WriteLine(c);
            }
            Console.WriteLine("-------------------");
            
            string d = "";
            for (int i = 0; i < N/2+1; i++)
            {
                d = "";
                for (int j = 0; j < i; j++)
                {
                    d += " ";
                }
                int t = N-2*i;
                for (int j = 0; j < t; j++)
                {
                    d += "*";
                }
                Console.WriteLine(d);
            }
            for (int i = 0; i < N/2; i++)
            {
                d = "";
                for (int j = 0; j < N/2-i-1; j++)
                {
                    d += " ";
                }
                for (int j = 0; j < 3 + 2 * i; j++)
                {
                    d += "*";
                }
                Console.WriteLine(d);
            }
            Console.WriteLine("~~~~~~~~~~~~~ 마모");
            int num = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= num; i++)
            {
                if (i <= (num / 2) + 1)
                {
                    string a = new string(' ', (num / 2) + 1 - i);
                    string b = new string('*', (i * 2) - 1);
                    Console.WriteLine(a + b);
                }
                else
                {
                    string c = new string(' ', i - (num / 2) - 1);
                    string d = new string('*', (num * 2) - ((i - 1) * 2) - 1);
                    Console.WriteLine(c + d);
                }
            }
        }
    }
}
