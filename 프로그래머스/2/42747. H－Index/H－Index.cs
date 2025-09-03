using System;

public class Solution
{
    public int solution(int[] citations)
    {
        Array.Sort(citations);
        Array.Reverse(citations);
        if (citations[0] < 1)
        {
            return 0;
        }


        for(int i = 0;  i < citations.Length; i++)
        {
            if (citations[i] >= i + 1)
            {
                if(i < citations.Length - 1 && citations[i + 1] < i + 2)
                {
                    return i + 1;
                }
            }
        }

        return citations.Length;
    }
}