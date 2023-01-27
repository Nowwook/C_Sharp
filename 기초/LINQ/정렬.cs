using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruit = { "cherry", "apple", "blueberry" };

            var 알파벳순서 = from word in fruit
                        orderby word
                              select word;
            foreach (var word in 알파벳순서) { Console.WriteLine(word); }
            // "apple", "blueberry", "cherry"

            var 길이순서 = from word in fruit
                       orderby word.Length
                              select word;
            // "apple", "cherry", "blueberry"


            double[] doubles = { 1.7, 2.3, 1.9, 4.1, 2.9 };

            var 내림차순 = from d in doubles
                                orderby d descending
                                select d;
            // 4.1, 2.9, 2.3, 1.9, 1.7


            string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            var 조건후뒤집기 = (
                from digit in digits
                where digit[1] == 'i'
                select digit)
                .Reverse();
            // "nine", "eight", "six", "five"


            string[] 비교연산자_활용 = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };

            var 정렬 = 비교연산자_활용.OrderBy(a => a, new CaseInsensitiveComparer());
            // "AbAcUs", "aPPLE", "BlUeBeRrY", "bRaNcH", "cHeRry", "ClOvEr"

            var 정렬_내림차순 = 비교연산자_활용.OrderByDescending(a => a, new CaseInsensitiveComparer());
            // "ClOvEr", "cHeRry", "bRaNcH", "BlUeBeRrY", "aPPLE", "AbAcUs"

            var 추가정렬 = 비교연산자_활용
                .OrderBy(a => a.Length)
                .ThenBy(a => a, new CaseInsensitiveComparer());
            // "aPPLE",
            // "AbAcUs", "bRaNcH", "cHeRry", "ClOvEr",
            // "BlUeBeRrY"

            var 추가정렬_내림차순 = 비교연산자_활용
                .OrderBy(a => a.Length)
                .ThenByDescending(a => a, new CaseInsensitiveComparer());
            // "BlUeBeRrY"
            // "AbAcUs", "bRaNcH", "cHeRry", "ClOvEr",
            // "aPPLE"
        }
    }

    // 비교연산자_구현
    public class CaseInsensitiveComparer : IComparer<string>
    {
        public int Compare(string x, string y) =>
            string.Compare(x, y, StringComparison.OrdinalIgnoreCase);
    }
}
