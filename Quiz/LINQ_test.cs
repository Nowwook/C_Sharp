/*
1. random을 사용하여 중복되지 않는  1 ~ 100 사이 요소를 가지고 있는 
   arr 배열을 만드세요. 
2. LINQ를 구문을 이용하여 75 ~ 95 까지 5의 배수만 정렬된 순서로 저장된 
   배열 arr2를 만들어 주세요.
3. arr2 요소를 화면에 출력합니다.
---------------------------------
75 80 85 90 95
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Quiz27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[100];
            int ran;
            bool flag;
            Random random = new Random();
            for(int i = 0; i < numbers.Length; i++)
            {
                flag = false;
                ran = random.Next(1, 101);
                for(int j = 0; j <= i; j++)
                {
                    if (numbers[j] == ran)
                    {
                        i--;
                        flag = true;
                        break;
                    }
                }
                if (flag == false)
                {
                    numbers[i] = ran;
                }

            }

            var linqNumbers = from num in numbers
                              where (75 <= num && num <= 95) && num % 5 == 0
                              orderby num
                              select num;
            foreach(int var in linqNumbers)
            {
                Console.Write(var + " ");
            }
        }
    }
}
