using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();    //줄 띄워서
            Console.Write();        //줄 붙여서
            
            Console.WriteLine($"{A} * {B} = {A * B}");      // 사칙연산
            
            Console.WriteLine("ㅁ{0,7:D}", "0번자리");      // 0번째를 7칸 중에 뒤로 붙이기(-7 앞에 붙이기)
            Console.Write("{0,2:D},{1,2:D},{2,2:D}", "0번", "1번", "2번");

            /*
            F - 실수(F5 > 소숫점 5자리)
            D - 정수("{0:D}", 0xFF) == 255
            X - 16진수(아스키코드)("{0:X}", 255) = ("{0:X}", 0xFF) == FF
            N - 콤마삽입      100.000
            E - 지수("{0:E}", 1234.567) == 1.234567E+003)
            */

            Console.WriteLine("{0,-8}DEF", "ABC");          // ABC DEF

            string 이름 = "{0,-20}{1,-15}{2,30}";           // 0번째는 20칸 앞에부터
            Console.WriteLine(이름, "abcdef", "efgh", "asda");

            /*
            \t 탭 (4칸 띄우기)
            \n 다음 줄
            \s 빈공간
            \S 채워진 공간
            \r 그 줄 맨앞
            */
            
            //----------------------------------
            
            // for, foreach
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            int[] arr = new[] { 0, 1, 2, 3, 4 };
            foreach (int i in arr)        //배열 순서대로 출력(타입 변수명 in 배열이름)
            {
                Console.WriteLine(i);
            }
            
            while (true)     // 조건
            {
                // 반복 실행
            }

            // do while
            do 
            {
                // 반복 실행
            }
            while (true);   // 이 조건이면 반복

            /*
            break       반복문 중단
            continue    해당 반복문 넘어가기
            */
            
            // 스위치 문
            int a = 0;
            switch (a)      // 받은 값
            {
                case 1:
                    break;
                case 2:
                    break;
            }


            string day = "x요일";
            switch (day)
            {
                case "월요일":
                case "화요일":
                case "수요일":
                case "목요일":
                case "금요일":
                    Console.WriteLine("평일입니다.");
                    break;
                case "토요일":
                case "일요일":
                    Console.WriteLine("휴일입니다.");
                    break;
            }
            
            //----------------------------------
            
            Convert.ToString(123456, 2);        // 2진수로 변환 (8진수,16진수 가능)

            Random random = new Random();       // 랜덤
            int x = random.Next(1, 45);         // 1~44


            // string[] A >> int[] B        배열 형식 변환
            string[] A = Console.ReadLine().Split(' ');
            int[] B = Array.ConvertAll(A, (e) => int.Parse(e));


            ConsoleKeyInfo ky = Console.ReadKey();  //키보드인식
            Console.WriteLine(ky.Key);              //키
            Console.WriteLine(ky.KeyChar);          //유니코드
            Console.WriteLine(ky.Modifiers);        // Ctrl, shift, alt
            
            //----------------------------------
            
            try
            {
                //실행할 문장
            }
            catch (Exception ex)        // Exception ex : 모든 에러
            {
                //예외 일때 실행
            }
            finally
            {
                //무조건 반환
            }

            try
            {
                Console.WriteLine("첫 실행"); 
                Console.WriteLine("exception 발생"); // 여기부터 실행 안됨

                Console.WriteLine("실행안됨");
            }
            catch (Exception ex)
            {
                Console.WriteLine("두번째 실행"); 
                return "네번째 실행"; 
            }
            finally
            {
                Console.WriteLine("세번째 실행");
                // finally 안에서 Exception 발생 예상시, finally 안에서 try 사용
            }
        }
    }
}
