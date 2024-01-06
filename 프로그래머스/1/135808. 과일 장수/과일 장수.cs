using System;

public class Solution {
    public int solution(int k, int m, int[] score) {
        Array.Sort(score);
        
        int answer = 0;
        
        for(int i = 0; i < score.Length / m; i++)
        {
            answer += score[score.Length % m + i * m] * m;
        }
        
        return answer;
    }
}