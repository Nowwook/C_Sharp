using System;

namespace Mathatics
{
    class Math
    {
        // 같은 이름의 함수 > 다른 매개변수
        public int Abs(int value)
        {
            return (value >= 0) ? value : 0;
        }
        public double Abs(double value)
        {
            return (value >= 0) ? value : -value;
        }

        // decimal 10진수
        public decimal Abs(decimal value)
        {
            return (value >= 0) ? value : -value;
        }
    
        internal class Program
        {
            static void Main(string[] args)
            {
                Math math = new Math();
                Console.WriteLine(math.Abs(-5));
                Console.WriteLine(math.Abs(-15.65));
                Console.WriteLine(math.Abs(20.01m));    // m = 10진수
            }
        }
    }
}
