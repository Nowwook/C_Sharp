using System;

// denum1 / num1 + denum2 / num2 = 기약분수

public class Solution {
    public int[] solution(int denum1, int num1, int denum2, int num2) {
        var denum = denum1 * num2 + denum2 * num1;
        var num = num1 * num2;
        var gcd = Gcd(denum, num);
        return new[] { denum / gcd, num / gcd };
    }

    public int Gcd(int a, int b)
    {
        if (b == 0)
            return a;
        if (a < b)
            return Gcd(b, a);
        return Gcd(b, a % b);
    }
}
