using System;
using System.Linq;

/*
n이하의 합성수의 개수를 return
*/

public class Solution {
    public int solution(int n) {
        int answer = 0;
        
        for (int i = 4; i <= n; i++)
        {
            answer += Enumerable.Range(1, n).Count(x => i % x == 0) >= 3 ? 1 : 0;
        }
        /*
        리스트나 배열에 숫자를 순서대로 넣기
        Enumerable.Range(시작 정수, 개수)
        */
        return answer;
    }
}
