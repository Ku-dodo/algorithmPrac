using System;

public class Solution
{
    public int[] solution(string[] keymap, string[] targets)
    {
        int[] answer = new int[targets.Length];

        for (int i = 0; i < targets.Length; i++)
        {
            answer[i] = keymapSearch(keymap, targets[i]);
        }
        return answer;
    }

    public int keymapSearch(string[] k, string s)
    {
        int result = 0;

        for (int i = 0; i < s.Length; i++)
        {
            int min = 0;
            for (int j = 0; j < k.Length; j++)
            {
                if (k[j].IndexOf(s[i]) == -1)
                {
                    continue;
                }
                else if (min == 0 || min >= k[j].IndexOf(s[i]) + 1)
                {
                    min = k[j].IndexOf(s[i]) + 1;
                }
            }
            if (min == 0)
            {
                return -1;
            }
            else
            {
                result += min;
            }
        }
        return result;
    }
}