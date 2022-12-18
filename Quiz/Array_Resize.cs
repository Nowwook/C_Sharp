using System;

# 나누어 떨어지는 값을 오름차순으로 정렬한 배열 반환

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        int[] answer = new int[arr.Length];
        int k = 0;
        for(int i=0; i<arr.Length; i++)
        {
            if(arr[i]%divisor == 0)
            {
                k++;
                answer[i] = arr[i];
            }
        }
        if(k == 0)
        {
            answer[0] = -1;
            Array.Resize(ref answer, 1);
            return answer;
        }
        Array.Sort(answer);
        Array.Reverse(answer);
        
        #  Array.Resize(ref answer, k)
        
        Array.Resize(ref answer, k);
        Array.Sort(answer);
        return answer;
    }
}
