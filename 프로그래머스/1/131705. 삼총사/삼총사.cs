using System;

public class Solution {
    public int solution(int[] number) {
        int answer = 0;
        for(int i = 0; i < number.Length; i++)
        {
            for(int j = i + 1; j < number.Length; j++)
            {
                for(int n = j + 1; n < number.Length; n++)
                {
                    if(number[i] + number[j] + number[n] == 0)
                    {
                        answer++;
                    }
                }
            }
        }
        
        return answer;
    }
}