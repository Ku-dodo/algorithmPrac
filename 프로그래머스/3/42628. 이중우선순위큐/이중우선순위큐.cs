using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(string[] operations)
    {
        int[] answer = new int[2];
        List<int> list = new List<int>();

        Queue<string> q = new Queue<string>();
        foreach (var s in operations)
        {
            q.Enqueue(s);
        }
        while (q.Count != 0)
        {
            string s = q.Dequeue();

            if (s[0] == 'I')
            {
                list.Add(int.Parse(s.Remove(0, 2)));
                list.Sort();
            }
            else if(list.Count != 0)
            {
                if (s == "D -1")
                {
                    list.Remove(list[0]);
                }
                else if (s == "D 1")
                {
                    list.Remove(list[list.Count - 1]);
                }
            }
        }

        if (list.Count == 0)
        {
            answer[0] = 0;
            answer[1] = 0;
        }
        else
        {
            answer[0] = list[list.Count - 1];
            answer[1] = list[0];
        }

        return answer;
    }
}