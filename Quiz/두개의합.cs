// 배열의 두 개의 수 합의 경우의 수를 오름차순으로
// [2,1,3,4,1]	>> [2,3,4,5,6,7]
// [5,0,2,7]	  >> [2,5,7,9,12]

using System;
using System.Linq;
using System.Collections.Generic;
public class Solution 
{
    public int[] solution(int[] numbers) 
    {
        Array.Sort(numbers);
        int k =0;
        int[] answer = new int[numbers[numbers.Length-1]+numbers[numbers.Length-2]];
        for(int i=0; i<numbers.Length-1; i++)
        {
            for(int j=i+1; j<numbers.Length; j++)
            {
                if(numbers[i]+numbers[j] != 0)
                {
                    answer[numbers[i]+numbers[j]-1] = numbers[i]+numbers[j];
                }
                else
                {
                    k++;
                }                   
            }
        }
        int[] answer2 = answer.Where(num => num != 0).ToArray();
        if( k != 0)
        {
            List<int> list = new List<int>(answer2.ToList());
            list.Add(0);
            answer2 = list.ToArray();
        }
        Array.Sort(answer2);
        return answer2;
    }
}

public class Solution2 
{
    public int[] solution(int[] numbers) 
    {
        List<int> answerList = new List<int>();

        for(int i = 0 ; i < numbers.Length -1 ; ++i){
            for(int j = i+1 ; j < numbers.Length ; ++ j)
                if(!answerList.Contains(numbers[i] + numbers[j]))
                    answerList.Add(numbers[i] + numbers[j]);
        }

        answerList.Sort();

        return answerList.ToArray();
    }
}
