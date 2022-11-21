using System;

// 원소 중 두 개를 곱해 만들 수 있는 최댓값
// [1, 2, -3, 4, -5] >> 15

public class Solution {
    public int solution(int[] numbers)
    {
        int maxLen = numbers.Length-1 ;
        Array.Sort(numbers) ;
        // MathF.Max  두 개의 수 중 더 큰 숫자를 반환
        return (int)MathF.Max(numbers[0]*numbers[1], numbers[maxLen]*numbers[maxLen-1]) ;
    }
}
