using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileStreamTest

    /*
     * System.IO.FileStream : 파일을 다루기 위한 BCL(Base Class Library)의 기본적 타입
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            // using을 쓰면 try catch 안해도된다.
            using (FileStream fs = new FileStream("c:\\temp\\test.log", FileMode.Create))
            {
                // fs를 받아와서 sw라는 파일을 쓴다.
                StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                sw.WriteLine("Hello World");
                sw.WriteLine("Anderson");
                sw.Write(32000); // 정수지만 문자열로 적힌다

                sw.Write("\n");
                for(int i = 'a'; i <= 'z'; i++)
                {
                    sw.Write((char)i + " ");
                }
                sw.Write("\n");
                for (int i = 'A'; i <= 'Z'; i++)
                {
                    sw.Write((char)i + " ");
                }
                sw.Write("\n");
                sw.WriteLine(DateTime.Now.ToString());
                sw.Flush(); 
            }
        }
    }
}

2.
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FileStreamTest
{
    /*
     * System.IO.FileStream : 파일을 다루기 위한 BCL(Base Class Library)의 기본적 타입
     */
    class Timer
    {
        int cnt = 1;
        public void Timer_start()
        {
            using (FileStream fs = new FileStream("c:\\temp\\test1.log", FileMode.Create))
            {
                while (true)
                {
                    StreamWriter sw = new StreamWriter(fs, Encoding.UTF8);
                    sw.Write($"[{cnt}] : {DateTime.Now.ToString()}\n");
                    sw.Flush();
                    cnt++;
                    Thread.Sleep(1000);
                }
            }
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Timer timer = new Timer();
            Thread t1 = new Thread(() => timer.Timer_start());
            t1.Start();
        }
    }
}
