using System;

public class Solution {
    public int[] solution(string s) {
        int[] answer = new int[s.Length];
        answer[0] = -1;
        for(int i = 1; s.Length - i >= 0; i++)
        {
            for (int j = 1; s.Length - (i + j) >= 0; j++)
            {
                if ((int)s[s.Length - i] == (int)s[s.Length - (i + j)])
                {
                    answer[s.Length - i] = (s.Length - i) - (s.Length - (i + j));
                    break;
                }
                if (s.Length - (i + j) == 0 && answer[s.Length - i] == 0)
                {
                    answer[s.Length - i] = -1;
                }
            }
        }
        return answer;
    }
}