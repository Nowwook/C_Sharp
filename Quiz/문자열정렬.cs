using System.Linq;
public class Solution {
    public string solution(string s) {
        string answer = "";
        char[] arr;
        arr = s.ToCharArray(0,s.Length);
        arr = arr.OrderByDescending(n => n).ToArray();
        return string.Join("", arr);
    }
}
