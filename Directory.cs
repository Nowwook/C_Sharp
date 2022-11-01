using System;
using System.IO;

namespace Directory_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 디스크 출력 C:\, D:\
            foreach (string txt in Directory.GetLogicalDrives())
            {
                Console.WriteLine(txt);
            }
            // 경로에 있는 파일 출력
            string target = @"C:\temp";
            foreach (string txt in Directory.GetFiles(target))
            {
                Console.WriteLine(txt);
            }
            Console.WriteLine("-------------------");

            // 경로에 있는 디렉토리(폴더) 출력
            string a = @"C:\Users\Admin\source\repos";
            foreach (string txt in Directory.GetDirectories(a))
            {
                Console.WriteLine(txt);
            }
            // 특정 형식 출력
            foreach(string txt in Directory.GetFiles(target,"*.png",SearchOption.AllDirectories))
            {
                Console.WriteLine(txt);
            }

        }
    }
}
