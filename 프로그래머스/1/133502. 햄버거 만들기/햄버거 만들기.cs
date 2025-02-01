using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] ingredient)
    {
        List<int> list = new List<int>();
        
        foreach (int i in ingredient)
        {
            list.Add(i);
        }

        int answer = 0;
        answer = package(list, answer);
        return answer;
    }


    public int package(List<int> li, int c)
    {
        int count = 0;
        for (int i = 0; i < li.Count - 3; i++)
        {
            if (li[i] == 1 && li[i + 1] == 2 && li[i + 2] == 3 && li[i + 3] == 1)
            {
                li.RemoveRange(i, 4);
                count++;
                i -= 4;
                if (i < -1) i = -1;
            }
        }

        return count == 0 ? c : package(li, c + count);
    }
}