using System;
public class Solution
{
    public int solution(int n)
    {
        bool[] bools = new bool[n];
        bools[0] = true;

        for (int i = 2; i <= n / 2; i++)
        {
            for (int j = 2; j * i <= n; j++)
            {
                bools[i * j - 1] = true;
            }
        }
        
        int answer = 0;
        foreach (var b in bools)
        {
            if (!b)
                answer++;
        }

        return answer;
    }
}