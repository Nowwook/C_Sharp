using System;

// 배열 원소중     n 과 가장 가까운수
// [3, 10, 28]	  20	>> 28
// [10, 11, 12]	  13	>> 12

public class Solution {
    public int solution(int[] array, int n) {
        int answer = 100;
        int t = 100;
        Array.Sort(array);
        foreach(var a in array)
        {
            if(t > Math.Abs(n-a))
            {
                answer = a;
                t = Math.Abs(n-a);
            }
        }
        return answer;
    }
}

/*
or
array.OrderBy(x => x).FirstOrDefault(x => Math.Abs(x - n) == array.Min(o => Math.Abs(o - n)));
array.OrderBy(x => x).OrderBy(x=>Math.Abs(x-n)).ToArray().First();
/*
