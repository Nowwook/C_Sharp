using System;

namespace Action_Test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Action ,Func, Predicate
            // Action 대리자 : 반환값이 없는 메서드 대신 호출
            // Func 대리자 : 매개변수와 반환값이 있는 메서드 호출
            // Predicate 대리자 : 매개변수에 대한 bool 값을 반환하는 메서드 대신 호출

            Action<string> printf = Console.WriteLine;
            printf.Invoke("메서드 대신 호출");
            printf("메서드 대신 호출");

            Func<int, int> abs = Math.Abs;
            Console.WriteLine(abs(-50));

            Func<double, double, double> pow = Math.Pow;
            Console.WriteLine(pow(2, 10));

            Func<string, string> toLower = str => str.ToLower();
            Console.WriteLine(toLower("ABCDEF"));

            Func<string, string, string> plus1 = delegate (string a, string b) { return $"{a}{b}"; };
            Console.WriteLine(plus1("Hell","ow"));
            Func<string, string, string> plus2 = (a,b)=> $"{a}{b}";
            Console.WriteLine(plus1("Hell", "ow"));


            Func<int, int> anonymous = delegate (int x) { return x * x; };
            Console.WriteLine(anonymous(2));

            // 같은거
            Func<int> getnum1 = delegate () { return 1234; };
            Func<int> getnum2 = () => 1234;
            Console.WriteLine(getnum1());
            Console.WriteLine(getnum2());

            Func<int, int> add1 = delegate (int x) { return x + 1; };
            Func<int, int> add2 =  x=> x + 1;
            Console.WriteLine(add1(10));
            Console.WriteLine(add2(10));

            Predicate<string> isNull = string.IsNullOrEmpty;
            Console.WriteLine(isNull("not null"));          // true , false

            Predicate<Type> isP = t => t.IsPrimitive;       // 기본 타입?
            Console.WriteLine(isP (typeof(long)));          // string - F
        }
    }
}
