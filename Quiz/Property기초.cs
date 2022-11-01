/'
Student class
인스턴스 필드 
1. 이름
2. 학번
3. 전화번호
4. 주소
4가지 속성을 모두 Property로 Get, Set이 가능하도록 클래스를 수정하세요.
'/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Quiz21
{
    class Student
    {
        private string name;
        private string stunum;
        private string phonenum;
        private string adress;
        public string Name
        {
            get;
            set;
        }
        public string Stunum
        {
            get;
            set;
        }
        public string Phonenum
        {
            get;
            set;
        }
        public string Adress
        {
            get;
            set;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
