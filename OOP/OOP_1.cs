using System;

namespace OOP01
{
    class Cat
    {
        // 멤버변수
        public string Name;
        public int Leg;
        // 생성자
        public Cat()
        {
            // 객체 초기화
            Console.WriteLine("생성자가 실행 됨");
            Name = "냥";
        }
        // default 생성자
        public Cat(string name)
        {
            Name = name;
        }
        public Cat(string name, int leg)
        {
            Name = name;
            Leg = leg;
        }
        
        ~Cat()  // 소멸자 표현, 잘 안함
        {
            Console.WriteLine("소멸자가 실행 됨");
        }
        
        // 멤버함수
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat tom1 = new Cat();
            Console.WriteLine(tom1.Name);
            Console.WriteLine();
            Cat tom = new Cat("톰");
            Console.WriteLine(tom.Name);
            Console.WriteLine(tom.Leg);
            Console.WriteLine();
            Cat kitty = new Cat("키티",4);
            Console.WriteLine(kitty.Name);
            Console.WriteLine(kitty.Leg);
            Console.WriteLine();
        }
    }
}
