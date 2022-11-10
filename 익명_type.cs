using System;

namespace Anonymous
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 익명 형식(anonymous type)
            var data = new { Id = 1, Name = "익명형식" };
            Console.WriteLine(data.Id + data.Name);

            var presenter = new { Name = "깅동", Age = 20, Topic = "C#" };
            Console.WriteLine($"{presenter.Name}  {presenter.Age}  {presenter.Topic}");

        }
    }
}
