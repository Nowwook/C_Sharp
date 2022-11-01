using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if (조건식) 
            {
                // 참일 경우에 실행될 문장
            } 
            else if (조건식) 
            {
                // 참일 경우에 실행될 문장
            } 
            else 
            {
                // 위의 조건식에 아무것도 해당하지 않을때 실행될 문장
            }
            
            byte b = 250; // 8비트 = 1byte : -128 ~ +127 , unsigned 0~255
            short s = b;  // 16비트 = 2byte ,-32768 ~ +32767 , 묵시적 형변환
            s = 256;
            Console.WriteLine(s);

            ushort u = 65;
            char c = (char)u; //명시적 형변환
            Console.WriteLine(c);

            int n = 40000;
            short s1 = (short)n;

            // const 한번 값이 할당되면 이후 변경 불가능
            const int MAX_INT = 32;
            MAX_INT = 64;  //수정불가

            int a = 3;
            Int32 b = 6;
            a = b;
            b = a;

            int c = 5;
            double d= 7;
            c = d;      // 타입이 다름, 대입물가
            d = c;      // 묵시적 형변환
        }
    }
}
