using System.Linq;
using System;

// 배열의 원소를 -1씩 n만큼 뺐을때 배열의 각원소 제곱의 합의 최소 
// [4, 3, 3]	n=4 >> 12

public class Solution {
    public long solution(int n, int[] works) {
        long answer = 0;
        if (works.Sum() > n)
        {
            int a = works.Length-1;
            Array.Sort(works);
            for (int i = 1; i <= n; i++)
            {
                works[a]--;
                if(a!=0)
                {
                    if(works[a]<works[a-1])
                    {
                        a--;
                    }
                    else
                    {
                        a = works.Length-1;
                    }
                }
            }
            foreach (var i in works)
            {
                answer += i * i;
            }
        }
        return answer;
    }
}
