using System;
using System.Collections.Generic;
using System.Linq;

public class Solution
{
    public int solution(int k, int[] tangerine)
    {
        Array.Sort(tangerine);
        Dictionary<int, int> counter = new Dictionary<int, int> ();
        foreach (int i in tangerine)
        {
            if (!counter.ContainsKey(i))
                counter.Add(i, 1);
            else
                counter[i]++;
        }

        counter = counter.OrderByDescending(item => item.Value)
            .ToDictionary(item => item.Key, item => item.Value);

        int answer = 0;
        int temp = 0;
        foreach (int i in counter.Values)
        {
            Console.WriteLine(i);
            if(temp >= k)
            {
                break;
            }
            temp += i;
            answer++;
        }

        return answer;
    }
}