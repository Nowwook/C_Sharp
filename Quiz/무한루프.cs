/'
[1] 1 
[2] 2
[3] 3
[q] 종료
----------------------------------------------
입력 : 1
입력 : 2
입력 : 3
입력 : 2
입력 : 1
입력 : q
프로그램이 종료되었습니다. 
---------------------------------------
'/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Quiz14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("[1] 1");
            Console.WriteLine("[2] 2");
            Console.WriteLine("[3] 3");
            Console.WriteLine("[q] 종료");
            ConsoleKeyInfo key;
            while (true)
            {
                Console.Write("입력 : ");
                key = Console.ReadKey();
                if (key.Key == ConsoleKey.Q)
                {
                    Console.WriteLine();
                    Console.WriteLine("프로그램이 종료되었습니다.");
                    break;
                }
                Console.WriteLine();
            }
        }
    }
}
