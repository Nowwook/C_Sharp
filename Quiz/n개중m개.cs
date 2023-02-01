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
