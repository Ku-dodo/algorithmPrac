using System;

public class Solution {
    public int solution(int[] d, int budget) {
        Array.Sort(d);
        int answer = 0;
        int i = 0;
        while(budget >= 0 && i < d.Length){
            if(d[i] <= budget)
            {
                budget -= d[i];
                i++;
                answer++;
            }
            else
            {
                budget -= d[i];
            }
        }
        
        return answer;
    }
}