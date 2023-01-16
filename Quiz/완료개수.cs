using System;
using System.Collections.Generic;

/*
각 기능은 진도가 100%일 때 서비스에 반영
뒤에 있는 기능은 앞에 있는 기능이 배포될 때 함께 배포
각 배포마다 몇 개의 기능이 배포되는지를 return

progresses	              speeds	            return
[93, 30, 55]	            [1, 30, 5]	        [2, 1]
[95, 90, 99, 99, 80, 99]  [1, 1, 1, 1, 1, 1]  [1, 3, 2]
*/

public class Solution {
    public int[] solution(int[] progresses, int[] speeds) {
        List<int> list = new List<int>();
        double[] num = new double[progresses.Length];
        
        for (int i = 0; i < progresses.Length; i++)
        {
            num[i] = Math.Ceiling((100 - (double)progresses[i]) / speeds[i]);
        }

        int a = 0;
        while (true)
        {
            if (a > progresses.Length-1) { break; }
            int b = (int)num[a];
            for (int i = a; i < num.Length; i++)
            {
                num[i] = num[i] - b;
            }

            while (true)
            {
                if (num[a] > 0)
                {
                    list.Add(a);
                    break;
                }
                a++;
                if (a > progresses.Length-1) { list.Add(a); break; }
            }
        }

        for(int i= list.Count-1; i>0; i--)
        {
            list[i] = list[i] - list[i-1];
        }

        return list.ToArray();
    }
/////////////////////
    public int[] solution2(int[] progresses, int[] speeds) {
        int k =1;
        int[] num = new int[progresses.Length] ;
        for(int i=0; i<progresses.Length; i++)
        {
            num[i] = (100 - progresses[i]) / speeds[i];
            if((100 - progresses[i])%speeds[i] !=0)
            {
                 num[i] = num[i]+1;
            }
        };
        List<int> lst = new List<int>();
        int count = num[0];
        int days = 0;
        for(int i=0; i<num.Length; i++)
        {
            if(i == num.Length-1)
            {
                if(count >= num[i])
                {
                    lst.Add(days + 1);
                }
                else if(count < num[i])
                {
                    lst.Add(days);
                    lst.Add(1);
                }
            }
            else if(count >= num[i])
            {
                days++;
            }
            else
            {
                lst.Add(days);
                count = num[i];
                days = 1;
            }
        }
        return lst.ToArray();
    }
/////////////////////
    public int[] solution(int[] progresses, int[] speeds) {
        int needDay = 0;
        List<int> s = new List<int>();
        for(int i=0;i<progresses.Length;i++)
        {
            int returnCount = 1;
            int count = 100 - progresses[i];
            needDay = count/speeds[i] + (count%speeds[i]==0 ? 0 : 1);
            for(int j=i+1;j<progresses.Length;j++)
            {
                count = 100 - progresses[j];
                int jNeedDay = count/speeds[j] + (count%speeds[j]==0 ? 0 : 1);
                if(needDay >= jNeedDay)
                {
                    returnCount++;
                    i++;
                } else
                {
                    break;
                }
            }
            s.Add(returnCount);
        }

        int[] answer = s.ToArray();
        return answer;
    }
}
