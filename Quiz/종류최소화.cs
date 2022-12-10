using System;
using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        List<int> list = new List<int>();
        Array.Sort(tangerine);
        int q = 1;
        if(tangerine.Length == 1)
        {
            answer = 1;
        }
        else
        {
            for(int i=0; i<tangerine.Length-1; i++)
            {
                if(i == tangerine.Length-2)
                {
                    list.Add(q);
                }
                else if(tangerine[i] == tangerine[i+1])
                {
                    q++;
                }
                else
                {
                    list.Add(q);
                    q = 1;
                }
            }
            if(tangerine[tangerine.Length-1] == tangerine[tangerine.Length-2])
            {
               list[list.Count-1] = list[list.Count-1] + 1;
            }
            else
            {
                list.Add(1);
            }
            list = list.OrderBy(x => -x).ToList();
            for(int i=0; i<list.Count; i++)
            {
                answer++;
                k = k - list[i];
                if(k <= 0)
                {
                    break;
                }
            }
        }
        
        return answer;
    }
}
