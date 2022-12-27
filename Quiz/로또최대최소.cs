using System;
using System.Linq;

public class Solution 
{
    public int[] solution(int[] lottos, int[] win_nums) 
    {
        int winCount = lottos.Intersect(win_nums).Count();
        int loseCount = lottos.Where((number) => number != 0).Count() - winCount;

        int[] answer = new int[] {Win(6-loseCount), Win(winCount)};
        return answer;
    }

    public int Win(int count)
    {
        if (count <= 1)
        {
            return 6;
        }
        return 7-count;
    }
    
    public int[] solution2(int[] lottos, int[] win_nums) 
    {
        int[] answer = new int[2];
        int k = 0;
        foreach(var i in lottos)
        {
            foreach(var j in win_nums)
            {
                if(i == j)
                {
                    k++;
                }
            }
        };
        
        int m = 0;
        foreach(var i in lottos)
        {
            if(i == 0)
            {
                m++;
            }
        };
        
        answer[0] = 7-k-m;
        answer[1] = 7-k;
        answer[0] = answer[0] == 7 ? 6 : answer[0];
        answer[1] = answer[1] == 7 ? 6 : answer[1];
        return answer;
    }
}
