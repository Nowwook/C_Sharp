/'
프로그램 명: hanoi
세 개의 탑(1,2,3 번 탑) 있고 첫번 째 탑에 접시가 쌓여져 있다. 단 접시는 작은 접시 위에 큰 접시가 쌓일수는 없다.
1 번 탑에 놓여져 있는 모든 접시를 3 번 탑으로 옮기는 문제이다. 단, 접시는 한 번에 하나씩 옮길 수 있고 , 이동 중간 단계에서도 작은 접시가 큰 접시위 위로 쌓일수는 없다.

입력
입력의 첫째 줄에는 1 번 탑에 싸여져 있는 접시수가 입력된다. 접시수는 10 을 넘지 않는다.
출력
최소 이동 방법을 출력예의 형식으로 출력한다.

입력
3

출력
1 -> 3
1 -> 2
3 -> 2
1 -> 3
2 -> 1
2 -> 3
1 -> 3
'/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Program
    {
        static StringBuilder sb = new StringBuilder();
        static int cnt = 0;
        public static void Quiz_sol(int a, int b, int c, int d)
        {
            if (a == 1)
            {
                sb.Append(b + " " + d + "\n");
                cnt++;
            }
            else
            {
                Quiz_sol(a - 1, b, d, c);
                sb.Append(b + " " + d + "\n");
                cnt++;
                Quiz_sol(a - 1, c, b, d);
            }
        }
        static void Main(string[] args)
        {
            Console.Write("숫자를 입력하세요 > ");
            int num = Int32.Parse(Console.ReadLine());
            Quiz_sol(num, 1, 2, 3);
            sb.Insert(0, cnt + "\n");
            Console.WriteLine(sb);
        }
    }
    
    or
    
    internal class Program
    {
        static void hanoi(int n, int x, int y, int z)
       {
            if (n > 0)
            {
                hanoi(n - 1, x, z, y);
                Console.WriteLine($"{x} -> {z}"+"\t");
                hanoi(n - 1, y, x, z);
            }
        }
        static void Main(string[] args)
        {
            // ex
            hanoi(3, 1, 2, 3);
        }
    }
}
