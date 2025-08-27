using System;
using System.Collections.Generic;

class Solution
{
    public int[] solution(int n, string[] words)
    {
        HashSet<string> str = new HashSet<string>();

        int count = 1;
        for (int i = 0; i < words.Length; i++)
        {
            if (str.Contains(words[i]))
                return new int[] { count % n == 0 ? n : count % n, (int)MathF.Ceiling((float)count / n) };
                str.Add(words[i]);

            count++;
            if (i < words.Length - 1 && words[i][words[i].Length - 1] != words[i + 1][0])
                return new int[] { count % n == 0 ? n : count % n, (int)MathF.Ceiling((float)count / n) };
        }

        return new int[] { 0, 0 };
    }
}