using System;
using System.IO;

namespace Path_test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string target = @"C:\\temp\\abc.txt";
            // 확장명 변경
            Console.WriteLine(Path.ChangeExtension(target,".dll"));
            
            // 디텍터리 정보 반환
            string p1 = Path.GetDirectoryName(target);
            Console.WriteLine(p1);
            
            // 절대 경로 반환
            string p2 = Path.GetFullPath(target);
            Console.WriteLine(p2);
            
            // 파일 이름 반환
            string p3 = Path.GetFileNameWithoutExtension(target);
            Console.WriteLine(p3);
        }
    }
}
