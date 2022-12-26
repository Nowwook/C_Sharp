using System;
using System.Collections.Generic;
using System.Linq;

/*
배열에서 0~9 중 없는 수의 합
[1,2,3,4,6,7,8,0]	 >> 5+9=14
[5,8,4,0,6,7,9]	   >> 1+2+3=6
*/

public class Solution {
    public int solution(int[] numbers) {
        var numberArray = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
        return numberArray.Except(numbers).Sum();
    }
}
