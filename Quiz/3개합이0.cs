using System;

// 배열                         경우의 수
// [-2, 3, 0, 2, -5]	        2
// [-3, -2, -1, 0, 1, 2, 3]	    5
// [-1, 1, -1, 1]	            0
    
public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        for(int i=0; i<number.Length-2; i++)
        {
            for(int j=i+1; j<number.Length -1; j++)
            {
                for(int k=j+1; k<number.Length; k++)
                {
                    if (number[i]+number[j]+number[k] == 0)
                    {
                        answer++;
                    }
                }
            }
        }
        return answer;
    }
}
