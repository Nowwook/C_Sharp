using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Q13
{
    internal class Program
    {
        // 로또번호 구하기
        static void Main(string[] args)
        {
            Random random = new Random();
            // 1단계 중복가능 
            Console.Write("로또번호: ");
            for (int i = 0; i < 6; i++)
            {
                int x = random.Next(1, 45);
                Console.Write(x + " ");
            }
            Console.WriteLine();
            Console.WriteLine("보너스번호: " + random.Next(1, 45));
            Console.WriteLine();

            // 2단계 중복 X, 정렬필요
            Console.Write("로또번호: ");
            int[] list = new int[7];
            int n;
            for (int i = 0; i < 7; i++)
            {
                n = random.Next(1, 46);
                for (int j = 0; j <= i; j++)
                {
                    if (n == list[j])
                    {
                        i--;
                    }
                    else
                    {
                        list[i] = n;
                        break;
                    }
                }
            }
            Array.Sort(list);            // 리스트 정렬
            for (int i = 0; i < 6; i++)
            {
                Console.Write(list[i] + " ");
            }
            Console.WriteLine();
            Console.WriteLine("보너스번호: " + list[6]);
        }
    }
}
