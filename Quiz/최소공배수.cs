using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(gg(4,5));
        }
        public static  int gcd(int n, int m)
        {
            // 최대공약수
            // 두 수 n, m 이 있을 때 어느 한 수가 0이 될 때 까지
            // gcd(m, n%m) 의 재귀함수 반복
            if (m == 0) return n;
            else return gcd(m, n % m);
        }
        public static int gg(int n, int m)
        {
            // 최소공배수
            return n * m / gcd(n, m);
        }
    }
}
