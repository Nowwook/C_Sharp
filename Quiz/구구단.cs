using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Q3
{
    internal class Program
    {
        /* 단을 입력하면 구구단 출력
        단: 5
        5 * 1 = 5
        ~
        5 * 9 = 45
        구구단 결과만 배열에 int[] dan
        */
        static void Main(string[] args)
        {
            Console.WriteLine("단 : ");
            int dan = Int32.Parse(Console.ReadLine());
            for (int i = 1; i < 10; i++)
            {
                Console.WriteLine($"{dan} * {i} = { dan * i }");
            }
            
            
            // 구구단 결과를 배열에 저장한 후 모두 출력 
            int[] result_gugudan = new int[72];
            int cnt = 0;
            for (int i = 2; i < 9; i++)
            {
                for (int j = 1; j < 9; j++)
                {
                    result_gugudan[cnt++] = i * j;
                }
            }
            for (int i = 0; i < result_gugudan.GetLength(0); i++)    // result_gugudan.GetLength(0)  1줄 다 출력
            {
                Console.Write(result_gugudan[i] + " ");
            }
        }
    }
}
