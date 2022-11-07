using System;

public class Solution {
    public string solution(string s) {
        s = s.ToLower();
        string answer = "";
        for(int i=0; i<s.Length; i++)
        {
            if(i == 0)
            {
                answer = answer + Char.ToUpper(s[i]);
            }
            else if (s[i] == ' ')
            {
                 answer = answer + ' ';
            }
            else if (s[i-1] == ' ')
            {
                 answer = answer + Char.ToUpper(s[i]);
            }
            else
            {
                 answer = answer + s[i];
            }
        }
        return answer;
    }
}
