using System;

namespace Binary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Convert.ToString(21474836, 2).PadRight(32,'*'));
                                                      // 2진수 변환, 32칸중 빈칸은 *

            int num1 = 1234;        // 명시적 explicit
            var num2 = 1234;        // 묵시적 imlicit
            var num3 = 3.1415;
            Console.WriteLine(num2.GetType());  // int32
            Console.WriteLine(num3.GetType());  // double
        }
    }
}
