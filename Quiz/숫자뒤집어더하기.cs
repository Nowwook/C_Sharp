using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Q7
{
    internal class Program
    {
        // 두 수 받아 뒤집어 더한 결과 뒤집어 출력 
        static void Main(string[] args)
        {
            Console.WriteLine("100,000,000 이하 두 자연수 입력 :");
            string A = Console.ReadLine();
            char[] a = A.ToCharArray();
            Array.Reverse(a);
            string str1 = new String(a);
            int x = Int32.Parse(str1);

            string B = Console.ReadLine();       // 문자로 받아서 
            char[] b = B.ToCharArray();          // 문자를 유니코드 배열로 
            Array.Reverse(b);                    // 배열 뒤집기
            string str2 = new String(b);         // 배열을 문자로
            int y = Int32.Parse(str2);           // 문자를 정수로

            int S = x + y;             
            string sum = S.ToString();           // 정수를 문자로
            char[] c = sum.ToCharArray();
            Array.Reverse(c);
            string str3 = new String(c);
            int d = Int32.Parse(str3);

            Console.Write($"{x} + {y} --> {d}");
        }
    }
}
