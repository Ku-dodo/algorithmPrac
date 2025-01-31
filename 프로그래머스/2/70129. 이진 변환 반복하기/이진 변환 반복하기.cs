using System;
using System.Text;

public class Solution
{
    public int[] solution(string s)
    {
        int[] answer = new int[2];
        StringBuilder sb = new StringBuilder();
        while (s.Length > 1)
        {
            answer[0] += 1;
            foreach (char c in s)
            {
                if (c == '1')
                {
                    sb.Append(c);
                }
                else
                {
                    answer[1] += 1;
                }
            }

            s = Convert.ToString(sb.Length, 2);
            sb.Clear();
        }
        return answer;
    }
}