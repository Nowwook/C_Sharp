using System;

// 쿠폰 10장당 서비스 1마리
// 서비스 치킨도 쿠폰 증정
// ex) 100 > 11

public class Solution {
    public int solution(int chicken) {
        int answer = 0;
        while(chicken >= 10)
        {
            chicken -= 10;

            answer++;
            chicken++;
        }
        return answer;
    }
}
