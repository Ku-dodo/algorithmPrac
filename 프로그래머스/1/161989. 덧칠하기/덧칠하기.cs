using System;

public class Solution {
    public int solution(int n, int m, int[] section) {
        bool[] drawPaint = new bool[n];
        for(int i = 0; i < drawPaint.Length; i++)
        {
            drawPaint[i] = true;
        }
        foreach(int i in section)
        {
            drawPaint[i - 1] = false;
        }
        
        int answer = 0;
        
        for(int i = 0; i < drawPaint.Length; i++)
        {
            if(drawPaint[i] == false)
            {
                for(int j = 0; j < m && i + j < drawPaint.Length; j++)
                {
                    drawPaint[i + j] = true;
                }
                answer++;
            }
        }
        return answer;
    }
}