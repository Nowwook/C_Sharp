using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Mathod
{
    class Calculator
    {
        // 입력받은 두수를 메소드 만들어 연산
        // plus(int a, int b),minus(),mutiple(),divide()
        public int plus(int a, int b)
        {
            return a + b;
        }
        public int minus(int a, int b)
        {
            return a - b;
        }
        public int mutiple(int a, int b)
        {
            return a * b;
        }
        public double divide(double a, double b)
        {
            return a / b;
        }
    }
    
    class Calculator2
    {
        public int sum(int a, int b, int c, int d)
        {
            return a + b + c + d;
        }
    }
    
    
    internal class Program
        {
            static void Main(string[] args)
            {
                Calculator cal = new Calculator();
                Console.WriteLine("두 숫자 입력 :");
                int a = Int32.Parse(Console.ReadLine());
                int b = Int32.Parse(Console.ReadLine());
                Console.WriteLine("덧셈 :" + cal.plus(a, b));
                Console.WriteLine("뺄셈 :" + cal.minus(a, b));
                Console.WriteLine("곱셈 :" + cal.mutiple(a, b));
                Console.WriteLine("나눗셈 :" + cal.divide(a, b));
            }
            /*
            static void Swap(ref int a ,ref int b)
            {
                int temp = a + b;
                Console.WriteLine($"{temp}");
            }
            static void Main2()
            {
                int a = 100, b = 200;
                Console.WriteLine($"{a},{b}");
                Swap(ref a, ref b);
            }
            */
        
            Calculator2 cal = new Calculator2();
            int total = cal.sum(100, 200, 300, 400);
            Console.WriteLine(total);
        }
        }
}
