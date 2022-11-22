using System;

// 수식이 옳다면 "O"를 틀리다면 "X"
// ["3 - 4 = -3", "5 + 6 = 11"]	>> ["X", "O"]
// ["19 - 6 = 13", "5 + 66 = 71", "5 - 15 = 63", "3 - 1 = 2"]	>> ["O", "O", "X", "O"]

public class Solution
{
    public string[] solution(string[] quiz)
    {
        string[] answer = new string[quiz.Length];

        for(int i=0; i<quiz.Length; i++)
        {
            string[] input = quiz[i].Split(' ');

            int a = int.Parse(input[0]);
            int b = int.Parse(input[2]);
            int c = int.Parse(input[4]);

            switch(input[1])
            {
                case "+":
                    if (a + b == c)
                        answer[i] = "O";
                    else
                        answer[i] = "X";
                    break;

                case "-":
                    if (a - b == c)
                        answer[i] = "O";
                    else
                        answer[i] = "X";
                    break;
            }
        }

        return answer;
    }
}
