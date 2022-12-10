using System;
using System.Collections.Generic;
using System.Linq;
public class Solution1 {
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

public class Solution2 {
    public int solution(int k, int[] tangerine) {
        int answer = 0;
        int rest = k ;
        Dictionary<int, int> sizeAndCount = new Dictionary<int, int>();
        for( int i = 0 ; i < tangerine.Length; i++)
        {
            if(sizeAndCount.ContainsKey(tangerine[i]))
            {
                sizeAndCount[tangerine[i]] +=1;
            }
            else 
            {
                sizeAndCount.Add(tangerine[i],1);
            }
        }
        foreach (KeyValuePair<int, int> items in sizeAndCount)
        {
            //System.Console.WriteLine(items.Key+"의 수량은"+items.Value);
        }
       var gg = sizeAndCount.OrderByDescending(x => x.Value);
        //System.Console.WriteLine("정렬");
        foreach (KeyValuePair<int, int> items in gg)
        {
            answer += 1;
            rest -= items.Value;
            if(rest <=0)
            {
                break; 
            }
            //System.Console.WriteLine(items.Key+"의 수량은"+items.Value);
        }
        return answer;
    }
}

public class Solution3 {
    public int solution(int k, int[] tangerine)
    {
        int answer = 0;
        Array.Sort(tangerine);
        List<int> list = new List<int>();
        list.Add(1);
        for(int i = 0; i < tangerine.Length - 1; i++)
        {
            if(tangerine[i] == tangerine[i + 1])
            {
                list[list.Count - 1]++;
            }
            else
            {
                list.Add(1);
            }
        }
        list.Sort();
        list.Reverse();
        for(int i = 0; i < list.Count; i++)
        {
            k -= list[i];
            if(k <= 0) { answer = i + 1; break; }
        }
        return answer;
    }
}
