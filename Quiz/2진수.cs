using System;
using System.Linq;

// 2진수

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

int answer = 0;
        int t = Regex.Matches(Convert.ToString(n,2), "1").Count;
        while(true) {   
            if( t == Regex.Matches(Convert.ToString(++n,2), "1").Count )
                break;
        }

        return n;
        
        public int solution(int n) 
    {
        int countOfOne = Convert.ToString(n, 2).ToArray().Where(d => d == '1').Count();

        while (true)
        {
            n++;

            if (countOfOne == Convert.ToString(n, 2).ToArray().Where(d => d == '1').Count())
                break;
        }

        return n;
    }
