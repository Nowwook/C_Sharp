using System;
using System.Linq;

// s에서 한 번만 등장하는 문자를 사전 순으로 정렬한 문자열을 return

public class Solution {
    public string solution(string s) {
        return string.Concat(s.Where(x => s.Count(o => o == x) == 1).OrderBy(x => x));;
    }
}
