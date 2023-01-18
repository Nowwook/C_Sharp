using System;
using System.Linq;

/*
배열속 특정 문자 카운트
*/

public class Solution {
    public int solution1(int[] array) {
        int answer = string.Join("", array).Count(x => x == '7');
        return answer;
    }
    
    public int solution2(int[] array) {
        int answer = 0;
        foreach(var i in array)
        {
            foreach(var j in i.ToString())
            {   
                if(j == '7')
                {
                    answer++;
                }
            }
        }
        return answer;
    }
}
