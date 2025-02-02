using System;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[,] clothes)
    {
        Dictionary<string, List<string>> parts = new Dictionary<string, List<string>>();
        List<string> pli = new List<string>();
        for (int i = 0; i < clothes.GetLength(0); i++)
        {
            if (!parts.ContainsKey(clothes[i, 1]))
            {
                pli.Add(clothes[i, 1]);
                parts.Add(clothes[i, 1], new List<string>());
                parts[clothes[i, 1]].Add(clothes[i, 0]);
            }
            else
            {
                parts[clothes[i, 1]].Add(clothes[i, 0]);
            }
        }
        

        int c = 1;
        foreach (var item in parts.Values)
        {
              c = c * (item.Count + 1);  
        }

        return c - 1;
    }
}