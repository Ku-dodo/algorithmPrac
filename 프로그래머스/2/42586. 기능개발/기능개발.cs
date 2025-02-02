using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] progresses, int[] speeds)
    {
        Queue<(int pro, int speed)> progressQueue = new Queue<(int pro, int speed)>();
        List<int> DeployList = new List<int>();

        for (int i = 0; i < progresses.Length; i++)
        {
            progressQueue.Enqueue((progresses[i], speeds[i]));
        }
        
        int daymem = 0;
        int index = 0;
        
        while (progressQueue.Count > 0)
        {
            var q = progressQueue.Dequeue();
            int compDay = (int)Math.Ceiling(((double)(100 - q.pro) / q.speed));
            if(DeployList.Count == 0)
            {
                daymem = compDay;
                DeployList.Add(1);
            }
            else
            {
                if(compDay <= daymem)
                {
                    DeployList[index]++;
                }
                else
                {
                    DeployList.Add(1);
                    daymem = compDay;
                    index++;
                }
            }
        }

       return DeployList.ToArray();
    }
}
