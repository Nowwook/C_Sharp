using System;

namespace CircleTest
{
    class Circle
    {
        public double pi = 3.14;
        private double Area(double radius)  // 내부에서만 접근 가능
        {
            return pi * radius * radius;
        }
        public void Print(double value)
        {
            Console.WriteLine(Area(value));
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 원 넓이
            Circle circle = new Circle();
            Circle o = new Circle();
            o.Print(10);
            Console.WriteLine(circle.Area(9)); // private 라 불가능
        }
    }
}
