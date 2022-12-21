public class Solution {
    public int[,] solution(int[,] arr1, int[,] arr2) {
        int[,] answer = new int[arr1.GetLength(0),arr1.GetLength(1)];
        for(int i =0; i<arr1.GetLength(0); i++)
        {
            for(int p =0; p<arr1.GetLength(1); p++)
            {
                answer[i,p] = arr1[i,p] + arr2[i,p];
            }
        }
        return answer;
    }
}
