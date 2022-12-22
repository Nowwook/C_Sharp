using System;
// x진수 덧셈
public class Solution {
    public string solution(int x, string bin1, string bin2) {
        string answer = Convert.ToString(Convert.ToInt32(bin1, x) + Convert.ToInt32(bin2, x), x);
        return answer;
    }
}
