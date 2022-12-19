using System;
using System.Linq;

// 모든 0을 제거 > 남은거 길이를 2진법으로 > 반복
/ 변환의 횟수와 변환 과정에서 제거된 모든 0의 개수 리턴
// "110010101001"	>> [3,8]
// "01110"	      >> [3,3]
// "1111111"    	>> [4,1]

public class Solution 
{
    public int[] solution(string s) 
    {
            int[] answer = new int[] { 0, 0 };
            while (!s.Equals("1"))
            {
                answer[0]++;
                var OneCharCount = s.Where(x => x.Equals('1')).Count();
                answer[1] += s.Length - OneCharCount;
                s = Convert.ToString(OneCharCount, 2);
            }
            return answer;
    }
}
