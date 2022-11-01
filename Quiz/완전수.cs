using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Q5
{
    // num의 약수 개수 num개인 완전수 num
    class sum_p
    {
        public void A(int num)
        {
            int cnt = 0;
            for (int i = 1; i < num; i++)
            {
                if (i <= num)
                {
                    if (num % i == 0)
                    {
                        cnt += i;
                    }
                }
            }
            if (cnt == num)
            {
                Console.WriteLine(num + " YES");
            }
            else
            {
                Console.WriteLine(num + " NO");
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            sum_p S = new sum_p();
            Console.WriteLine("1000 이하의 수 입력 : ");
            int b = Int32.Parse(Console.ReadLine());
            S.A(b);
            // 1000 이하 완전수를 입력 받아 yes, no 출력
        }
    }
}
