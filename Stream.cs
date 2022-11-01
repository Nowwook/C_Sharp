using System;
using System.IO;
using System.Text;

namespace Stream_Test
{
    // c# 문자열 읽,쓰기
    // 읽기 : StreaamReader
    // 쓰기 : StreaamWriter
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 문자열 >> UTF8 형식으로 직렬화
            MemoryStream ms = new MemoryStream();
            byte[] buf = Encoding.UTF8.GetBytes("Hello World");
            ms.Write(buf, 0, buf.Length);
            */

            // StreaamWriter
            MemoryStream ms = new MemoryStream();
            StreamWriter sw = new StreamWriter(ms,Encoding.UTF8);
            sw.WriteLine("Hello World");
            sw.WriteLine("Anderson");
            sw.Write(320000);
            sw.Flush();

            // ms에서 읽고 콘솔에 출력
            ms.Position = 0;
            StreamReader sr = new StreamReader(ms,Encoding.UTF8);
            string line = sr.ReadToEnd();
            Console.WriteLine(line);
        }
    }
}
