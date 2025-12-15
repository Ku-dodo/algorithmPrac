using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int[] priorities, int location)
    {
        Queue<(int idx, int pri)> queue = new Queue<(int, int)> ();
        for (int i = 0; i < priorities.Length; i++)
        {
            queue.Enqueue((i, priorities[i]));
        }

        int order = 0;
        while (queue.Count > 0)
        {
            var current = queue.Dequeue ();

            if (queue.Any(item => item.pri > current.pri))
            {
                queue.Enqueue (current);
            }
            else
            {
                order++;
                if (current.idx == location)
                {
                    return order;
                }
            }
        }

        return 0;
    }
}