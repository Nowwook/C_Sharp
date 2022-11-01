using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Quiz07
{
    class Shape
    {
        public virtual void draw()
        {
            Console.WriteLine("도형을 그리다");
        }
    }
    class Triangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("삼각형을 그리다");
        }
    }
    class Rectangle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("사각형을 그리다");
        }
    }
    class Circle : Shape
    {
        public override void draw()
        {
            Console.WriteLine("원을 그리다");
        }
    }
    
    internal class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Shape();
            shape.draw();
            
            Triangle triangle = new Triangle();
            triangle.draw();
            
            Rectangle rectangle = new Rectangle();
            rectangle.draw();
            
            Circle circle = new Circle();
            circle.draw();
        }
    }
}
