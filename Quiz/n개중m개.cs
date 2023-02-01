using System;

public class Solution {
    public int solution(int balls, int share) {
        int answer = 0;
        double count = perm(balls) / (perm(balls - share) * perm(share));
        answer =  Convert.ToInt32(count);
        return answer;
    }

    double perm(int n)
    {
        double temp = 1;
        for(int i=2; i <= n ;i++)
        {
            temp *= i;
        }
        return temp;
    }
}

// 재귀사용
using System;
using System.Numerics;

public class Solution 
{
    public int solution(int balls, int share)
    {
        return Combination(balls, share);
    }

    public int Combination(int n, int m)
    {
        if (m == 0 || n == m) 
        {
            return 1;
        }

        return Combination(n - 1, m - 1) + Combination(n - 1, m);
    }
}

using System;

public class Solution {
    public long solution(long balls, long share) {
        long answer = 0;
        long a = balls-share;
        long e =0;
        long d=1;
        long f= 1;
        if( a>share)
        {
            e=share;
        }
        else
        {
            e=a;
        }
        if(balls==share)
        {
            answer=1;
        }
        else
        {
            for(long i =0; i < e; i++)
            {
                d = d*(balls-i)/(i+1);
            }
            answer= d;

        }
        return answer;
    }
}
