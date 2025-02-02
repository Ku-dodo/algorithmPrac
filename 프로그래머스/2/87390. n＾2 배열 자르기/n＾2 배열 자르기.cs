using System;

public class Solution {
    public int[] solution(int n, long left, long right) {
        int[] answer = new int[right - left + 1];
        
        for(int i = 0; i < answer.Length; i++){
            answer[i] = (left % n + 1) >= (left / n + 1) ? (int)(left % n + 1) : (int)(left / n + 1);
            left++;
        }
        
        
        return answer;
    }
}