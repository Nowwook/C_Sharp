using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Q28
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // (홀수)마방진
            int x = Int32.Parse(Console.ReadLine());
            int[,] a = new int[x, x];
            int y = 0,z=x/2;
            a[y, z] = 1;
            for (int i = 2; i <= x*x; i++)
            {
                if (i%x==1)
                {
                    y++;
                }
                else
                {
                    if (y > 0)
                    {
                        y -= 1;
                    }
                    else
                    {
                        y = x - 1;
                    }
                    if (z == x - 1)
                    {
                        z = 0;
                    }
                    else
                    {
                        z++;
                    }
                }
                a[y, z] = i;
            }
            for(int i = 0; i < x; i++)
            {
                for(int j = 0; j < x; j++)
                {
                    Console.Write(a[i,j]+"\t");
                }
                Console.WriteLine();
            }    
            
        }
    }
}
