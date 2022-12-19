// n^2 배열 자르기
/*
  123
  223
  333
  이어붙인 1차원 배열의
  arr[left] ~ arr[right] 인 배열 
  
  n	 left	 right	result
  3	 2	   5	    >> [3,2,2,3]
  4	 7	   14	    >> [4,3,3,3,4,4,4,4]
*/

using System;
using System.Collections.Generic;

public class Solution 
{
    public int[] solution(int n, long left, long right) 
    {
        int[] answer = new int[] {};
        List<int> resultList = new List<int>();
        while (left <= right) 
        {
            resultList.Add(Math.Max((int)(left / n), (int)(left++ % n)) + 1);        
        }
        return resultList.ToArray();
    }
}
