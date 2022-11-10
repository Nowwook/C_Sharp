using System;

namespace Partial_test
{
    // 같은 클래스 나누기 partial
    public partial class Hello
    {
        public void Hi() => Console.WriteLine("Partial 1");
    }
    public partial class Hello
    {
        public void bye() => Console.WriteLine("Partial 2");
    }
    class Program
    {
        static void Main()
        {
            Hello hello =new Hello();
            hello.Hi();
            hello.bye();
        }
    }
}
