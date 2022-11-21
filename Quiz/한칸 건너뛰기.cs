using System;

// 공은 1번부터 던지며 오른쪽으로 한 명을 건너뛰고 그다음 사람에게만 던짐
// k번째로 공을 던지는 사람의 번호
// [1, 2, 3, 4]	k=2	>> 3

public class Solution {
    public int solution(int[] numbers, int k) {
        return numbers[(k * 2 - 2) % numbers.Length];
    }
}
