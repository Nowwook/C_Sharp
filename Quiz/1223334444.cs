using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApp_Quiz25
{
    class Gold_coin
    {
        public int day_pay(int day)
        {
            int[] pay_sum = new int[day];
            int day_pay = 1;
            int sum = 0;
            while(sum < day)
            {
                sum = 0;
                for(int i = 1; i <= day_pay; i++)
                {
                    sum = sum + i;
                }
                day_pay++;
            }
            return day_pay-1;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("날 수를 입력하시오 > ");
            int day = Int32.Parse(Console.ReadLine());
            Gold_coin gold = new Gold_coin();
            int sum = 0;
            for (int i = 1; i <= day; i++)
            {
                sum = sum + gold.day_pay(i)
            }
            Console.WriteLine(day + " " + sum);
        }
    }
}
