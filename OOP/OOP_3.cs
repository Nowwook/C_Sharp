using System;

namespace OOP02
{
    class Cat
    {
        private string name;  // 속성, 직접접근X, 간접접근

        /*
        Getter, Setter
         public void setName(string name)
        {
            name = name;
        }
        public string getName()
        {
            return this.name;   // this 생략가능
        }
        */

        public string Name     // 프로퍼티
        {
            get;      // { return name; } 생략 가능
            set;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat tom = new Cat();
            // tom.setName("톰");
            // Console.WriteLine(tom.getName());
            tom.Name = "톰";
            Console.WriteLine(tom.Name);
        }
    }
}
