using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyApp_Quiz34
{
    class Calculator
    {
        public int Plus(int a, int b)
        {
            return a + b;
        }
        public int Minus(int a, int b)
        {
            return a - b;
        }
        public int mul(int a, int b) => a * b;
        public double div(double a, double b) => a / b;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            // 델리게이트와 비동기 객체를 사용하여 스레드 구현
            Calculator calculator = new Calculator();
            Func<int, int, int> plus = calculator.Plus;
            Func<int, int, int> minus = calculator.Minus;
            Func<int, int, int> mul = calculator.Mul;
            Func<int, int, double> div = calculator.Div;

            // IAsyncResult를 통해 스레드 생성
            IAsyncResult asyncRes_plus = plus.BeginInvoke(10, 20, null, null);
            int result_plus = plus.EndInvoke(asyncRes_plus);
            IAsyncResult asyncRes_minus = minus.BeginInvoke(10, 20, null, null);
            int result_minus = minus.EndInvoke(asyncRes_minus);
            IAsyncResult asyncRes_mul = mul.BeginInvoke(10, 20, null, null);
            int result_mul = mul.EndInvoke(asyncRes_mul);
            IAsyncResult asyncRes_div = div.BeginInvoke(10, 20, null, null);
            double result_div = div.EndInvoke(asyncRes_div);

            // 출력
            Console.WriteLine(result_plus);
            Console.WriteLine(result_minus);
            Console.WriteLine(result_mul);
            Console.WriteLine(result_div);
        }
    }
}
