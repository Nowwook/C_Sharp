using System;
using System.Threading;

namespace Thread_monitor_Lock_test
{
    class MyData
    {
        int num = 0;
        public object Lock = new object();
        // lock 이 없다면 200000 카운트 전에 종료됨
        // 1개의 스레드만 접근 가능하도록 lock
        public int Num { get { return num; } }
        public void count()
        {
            // object Lock = new object() 을 메서드 안에서 생성시 동기화 안됨
            lock (Lock)
            {
                num++;
            }
        }
    }
    // List 와 Dictionary 를 스레드로부터 안전하게 캡슐화시킨
    // ConcurrentBag, ConcurrentDictionary 키워드

    // 불필요한 lock, ConcurrentBag, ConcurrentDictionary 의 사용은 성능저하의 원인
    internal class Program
    {
        static void Main(string[] args)
        {
            MyData data = new MyData();
            Thread t1 = new Thread(threadfunc);
            Thread t2 = new Thread(threadfunc);
            t1.Start(data);
            t2.Start(data);

            t1.Join();
            t2.Join();
            Console.WriteLine(data.Num);
        }
        static void threadfunc(object A)
        {
            MyData data = A as MyData;
            for (int i = 0; i < 100000; i++)
            {
                data.count();
            }
        }
    }
}
