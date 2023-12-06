using System;

public class Solution {
    public int solution(int[,] sizes) {
        int temp = 0;
        int maxWidth = 0;
        int maxHeight = 0;
        for (int i = 0; i < sizes.GetLength(0); i++)
        {
            if(sizes[i,0] > sizes[i,1])
            {
                temp = sizes[i,0];
                sizes[i,0] = sizes[i,1];
                sizes[i,1] = temp;      
            }
            if (maxWidth < sizes[i,0])
            {
                maxWidth = sizes[i,0];
            }
            if (maxHeight < sizes[i,1])
            {
                maxHeight = sizes[i,1];
            }
        }
        int answer = maxWidth * maxHeight;
        return answer;
    }
}