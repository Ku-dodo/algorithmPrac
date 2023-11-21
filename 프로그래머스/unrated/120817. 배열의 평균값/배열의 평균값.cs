using System;

public class Solution {
    public double solution(int[] numbers) {
        double answer = ((double)numbers[0] + (double)numbers[numbers.Length - 1])/2;
        return answer;
    }
}