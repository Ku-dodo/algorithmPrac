using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(int[] elements)
    {
        HashSet<int> hash = new HashSet<int>();

        for(int i = 0; i < elements.Length; i++)
        {
            int a = 0;
            for(int j = 0; j < elements.Length; j++)
            {
                a += elements[(i + j)% elements.Length];
                hash.Add(a);
            }
        }
        int answer = hash.Count;
        return answer;
    }
}