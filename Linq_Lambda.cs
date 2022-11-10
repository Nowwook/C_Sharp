using System;
using System.Linq;
 
namespace Linq_Simple_Example
{
    class Profile
    {
        public string Name { get; set; }
        public int    Height { get; set; }
    }
 
    class Program
    {
        static void Main(string[] args)
        {
            Profile[] arrProfile =
            {
                new Profile(){Name = "정우성", Height = 186},
                new Profile(){Name = "김태희", Height = 158},
                new Profile(){Name = "고현정", Height = 172},
                new Profile(){Name = "이문세", Height = 178},
                new Profile(){Name = "하하", Height = 171}
            };
 
            var profiles = arrProfile.Where(profile => profile.Height < 175).
                                      OrderBy(profile => profile.Height).
                                      Select(profile => new
                                      {
                                          Name = profile.Name,
                                          Height = profile.Height
                                      });
 
            foreach (var profile in profiles)
            {
                Console.WriteLine($"이름 : {profile.Name}, 키 : {profile.Height}");
            }
            
            // 조건(x==n) 대로 카운트 
            int[] array =new int[] {1, 2, 3, 4, 5};
            int n = 3;
            int answer = array.Count(x => x == n);
        }
    }
}
