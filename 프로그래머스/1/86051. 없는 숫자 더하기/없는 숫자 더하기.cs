using System;

public class Solution {
    public int solution(int[] numbers) {
        int answer = 45;
        foreach (int number in numbers)
        {
            answer -= number;
        }
        return answer;
    }
}