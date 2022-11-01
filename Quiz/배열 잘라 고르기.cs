// ex) a = [1, 5, 2, 6, 3, 7, 4]
//  [i, j, k] = [2, 5, 3]
//  a의 2~5번째 골라서 오름차순 정열 후 3번째

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A q = new A();

            int[] a = { 1, 5, 2, 6, 3, 7, 4 };
            int[,] b = { { 2, 5, 3 }, { 4, 4, 1 }, { 1, 7, 3 } };

            int[] c = q.solution(a, b);
            foreach (int i in c)
                Console.WriteLine(i);
        }
    }
    public class A
    {
        public int[] solution(int[] array, int[,] commands)
        {
            int[] answer = new int[commands.Length / 3];
            for (int i = 0; i < commands.Length / 3; i++)
            {
                int[] num = new int[commands[i, 1] - commands[i, 0] + 1];
                int p = 0;
                for (int k = commands[i, 0] - 1; k < commands[i, 1]; k++)
                {
                    num[p] = array[k];
                    p++;
                }
                Array.Sort(num);
                p = 0;
                answer[i] = num[commands[i, 2] - 1];
            }
            return answer;
        }
    }
}

///////////
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] array, int[,] commands) {
        int[] answer = new int[commands.GetLength(0)];
        List<int> lst = new List<int>(array);
        for (int i = 0; i < commands.GetLength(0); i++)
        {
            int nStart = commands[i, 0];
            int nEnd = commands[i, 1];
            int nIndex = commands[i, 2];
            List<int> lstSub = lst.Where((x, idx) => idx >= nStart - 1 && idx < nEnd).OrderBy(x => x).ToList();
            answer[i] = lstSub[nIndex - 1];
        }
        return answer;
    }
}
