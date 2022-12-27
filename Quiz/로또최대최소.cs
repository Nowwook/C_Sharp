using System;
using System.Linq;

/*
로또 번호를 담은 배열 lottos, 당첨 번호를 담은 배열 win_nums가 매개변수
당첨 가능한 최고 순위와 최저 순위를 차례대로 배열에 담아서 return
[44, 1, 0, 0, 31, 25]	[31, 10, 45, 1, 6, 19]	  >>    [3, 5]
[0, 0, 0, 0, 0, 0]	    [38, 19, 20, 40, 15, 25]  >>    [1, 6]
[45, 4, 35, 20, 3, 9]	[20, 9, 3, 45, 4, 35]	  >>    [1, 1]
*/
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
