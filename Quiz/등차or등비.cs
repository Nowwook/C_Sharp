using System;

public class Solution {
    public int solution(int[] c) {
        int answer = 0;
         if(c[1]-c[0] == c[2]-c[1])
        {
            return c[c.Length-1] + c[2] - c[1];
        }
        return c[c.Length-1]*(c[1]/c[0]);
    }
}
