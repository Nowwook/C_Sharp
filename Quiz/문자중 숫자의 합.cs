using System;

/*
문자열에서 자연수들의 합
"aAb1B2cC34oOp" 37
"1a2b3c4d123Z"  133
*/

public class Solution {
    public int solution(string my_string) {
        int answer = 0;
        string temp = "0";

        foreach (var c in my_string)
        {
            if (char.IsNumber(c))
            {
                temp += c;
            }
            else
            {
                answer += Convert.ToInt32(temp);
                temp = "0";
            }
        }
        
        answer += Convert.ToInt32(temp);
        return answer;
    }
/////////////////////
    public int solution(string my_string)
        {
            int answer = 0;
            string Num = Regex.Replace(my_string, @"\D", ",");
            string[] Aarray = Num.Split(',');

            foreach (var i in Aarray)
            {
                if (i != "") { answer = answer + Int32.Parse(i); }
            }
            return answer;
        }
    
}
