using System;

namespace ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            - Buffer.BlockCopy(원본배열, 원본배열의 복사 시작위치, 복사될배열, 복사될배열의 시작위치, 복사개수)
              빠르지만 byte 형식에서만 사용가능

            - Array.Copy(원본배열, 원본배열의 복사 시작위치, 복사될배열, 복사될배열의 시작위치, 복사개수)

            - Array.Copy(원본배열, 복사될배열, 복사개수) - 인덱스 0부터 복사개수만큼 복사함
            */

            byte[] a = { 1, 2 };
            byte[] b = new byte[a.Length];

            Buffer.BlockCopy(a, 0, b, 0, a.Length);

            foreach (var item in b)
            {
                Console.WriteLine(item);
            }

            string[] c = { "1", "2" };
            string[] d = new string[a.Length];

            Array.Copy(c, d, c.Length);

            foreach (var item in d)
            {
                Console.WriteLine(item);
            }
        }
    }
}
