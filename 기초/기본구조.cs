using System;
 
namespace MyApp {
    class HelloWorld {
        static void Main(string[] args) {
            Console.WriteLine("Hello World");
            Console.ReadKey();
        }
    }
}

/*
using System;
- System 이라는 네임스페이스를 프로그램에 포함시킵니다.

namespace MyApp { }
- 네임스페이스(클래스의 모음)를 선언

class HelloWorld {}
- 클래스(메소드)를 선언

static void Main(string[] args) {}
- Main 함수는 C#프로그램의 진입점

Console.WriteLine("Hello World");
- 콘솔 클래스(System 네임스페이스)를 이용하여 화면에 "Hello World" 출력

Console.ReadKey();
- 프로그램이 키 입력을 기다림 (프로그램 자동 종료 방지 등)
*/
