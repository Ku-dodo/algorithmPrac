using System;
public class Solution {
    public long solution(int a, int b) {
        double answer = (a + b) * (double)(Math.Abs(a - b) + 1) / 2;
        return (long)answer;
    }
}