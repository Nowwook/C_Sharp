using System;
using System.IO;
using System.Threading;

namespace time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StreamWriter sw = new StreamWriter("C:\\Users\\Admin\\code\\time.txt");
            for(int i = 0; i < 10; i++)
            {
                // 1초마다 현재시간 txt에 저장
                Thread.Sleep(1000);
                sw.WriteLine(DateTime.Now.ToString());
            }
            sw.Close();
        }
    }
}
