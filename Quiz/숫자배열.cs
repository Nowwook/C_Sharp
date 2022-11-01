using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Format_Q01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0.5 단계
            for (int i = 10; i > 0; i--)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
            Console.WriteLine("----------------------");
            int[] num = new int[5];
            int z = 0;
            for (int i = 10; i > 0; i--)
            {
                if (i % 2 != 0)
                {
                    num[z] = i;
                    z++;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(num[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------");
            int[] A = new int[10];
            int y = 0;
            for (int i = 1; i <= 10; i++)
            {
                if (i % 2 == 0)
                {
                    A[y] = i;
                    y++;
                }
            }
            for (int i = 0; i < 5; i++)
            {
                Console.Write(A[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("-------------------");

            /* 1단계 
             * N=5
             * 1  6 11 16 21
             * 2  7 12 17 22
             * 3  8 13 18 23
             * 4  9 14 19 24
             * 5 10 15 20 25
            */

            int N = Int32.Parse(Console.ReadLine());
            int[] B = new int[N];
            for (int i = 0; i < N; i++)
            {
                int q = 0;
                for (int j = 1; j <= N * N; j = j + N)
                {
                    B[q] = j;
                    q++;
                }
                Console.Write(B[i] + " ");
            }
            Console.WriteLine();
            for (int j = 0; j < N - 1; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    B[i] = B[i] + 1;
                    Console.Write(B[i] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("---------------");

            // 2단계
            int[] C = new int[N];
            for (int i = 0; i < N; i++)
            {
                int q = 0;
                for (int j = N * N; j >= (N * N) - N + 1; j--)
                {
                    C[q] = j;
                    q++;
                }
                Console.Write(C[i] + "\t");
            }
            Console.WriteLine();
            for (int j = 0; j < N - 2; j++)
            {
                for (int i = 0; i < N; i++)
                {
                    C[i] = C[i] - N;
                    Console.Write(C[i] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < N; i++)
            {
                C[i] = C[i] - N;
                Console.Write(C[i] + "\t");
            }
            Console.WriteLine();
            
            Console.WriteLine("---------------");
            Console.WriteLine("입력 :");
            int A = int.Parse(Console.ReadLine());
            for (int t = A; t > 0; t--)
            {
                for (int q = 0; q > -A; q--)
                {
                    Console.Write(t * A + q + "\t");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("--------달팽이-----------------");
            Console.WriteLine("입력 :");
            int B = Int32.Parse(Console.ReadLine());
            int[,] num = new int[B, B];
            int w = 0, j = -1, k = 0, n = 1,p=B;
            while (true)
            {
                for (int t = 0; t < B; t++)
                {
                    k++;
                    j = j + n;
                    num[w, j] = k;
                }
                B = B - 1;
                if (B <= 0) break;
                for (int m = 0; m < B; m++)
                {
                    k++;
                    w = w + n;
                    num[w, j] = k;
                }
                n *= -1;
            }
            for (int q = 0; q < p; q++)
            {
                for (int l = 0; l < p; l++)
                {
                    Console.Write(num[q, l] + "\t");
                }
                Console.WriteLine();
            }
            }
        }
    }
}
