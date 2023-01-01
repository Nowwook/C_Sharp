using System;

namespace Struct
{
    /*
    구조체
    사용자 정의 데이터 유형(Data Type)으로 int, double 등과 같은 기본적으로 제공되는 변수 유형이 아닌
    사용자가 직접 만들어 사용
    .(점)을 통해 접근
    상속 
    */
    struct School
    {
        public string name1;
        public string name2;
        public int num;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            School sc;
            sc.name1 = "길동";
            sc.name2 = "고등학교";
            sc.num = 2;
            Console.WriteLine("{0}이는 {1}{2}학년", sc.name1, sc.name2, sc.num);
        }
    }
}
