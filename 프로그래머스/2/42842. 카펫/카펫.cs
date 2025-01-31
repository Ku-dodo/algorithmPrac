using System;

public class Solution {
    public int[] solution(int brown, int yellow) {
        int[] answer = new int[2];
        
        for(int y = 3; brown / 2 - (y - 2) >= 3; y++)
        {
            if((y - 2) * ((brown / 2) - y) == yellow)
            {
                answer[0] = (brown / 2) - y + 2;
                answer[1] = y;
                break;
            }
        }
        return answer;
    }
}