using System;
using System.Linq;

// 주어진 자연수 n을 2진수로 변경했을때 n보다 크면서 1의 개수가 같은 수의 최솟값 

class Solution 
{
    public int solution(int n) 
   {
        int answer = 0;
        string k = Convert.ToString(n, 2);
        int q = k.Count(x => (x == '1'));
        while(answer == 0)
        {
            n++;
            string k_1 = Convert.ToString(n, 2);
            int p = k_1.Count(x => (x == '1'));
            if(q ==p)
            {
                answer = n;
            }
        }
        return answer;
    }
}

/*
2진수 k에서 1을 카운트 하는법
k.Count(x => (x == '1'));
Regex.Matches(k, "1").Count;
k.ToArray().Where(d => d == '1').Count();
*/
