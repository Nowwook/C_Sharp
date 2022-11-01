using System;

namespace NameParameter
{
    internal class Program
    {
        // 명명된 인수 문법
        static void PrintPro(string name, string phone)         // 함수 선언
        {
            Console.WriteLine($"Name : {name},Phone : {phone}");
        }
        static void Main(string[] args)
        {
            PrintPro(name:"박찬호",phone : "010-1234");
            PrintPro(phone: "010-1234", name: "박찬호");
            PrintPro("박찬호", "010-1234");              // 일반벅인 방법
            PrintPro("박찬호", phone: "010-1234");
        }
    }
}
