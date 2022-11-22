using System;

// 3의 배수와 숫자 3을 사용하지 않고 카운트
// 15	>> 25

public class Solution {
    public int solution(int n) {
        int answer = 0;
        for(int i=0;i<n;i++)
        {
            answer++;
            while(answer%3==0 || answer.ToString().Contains("3"))
            {
                answer++;
            }
        }
        return answer;
    }
}
