using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] numbers) {
        List<int> intL = new List<int>();
        for(int i = 0; i < numbers.Length; i++)
        {
            int sum = 0;
            for(int j = i + 1; j < numbers.Length; j++)
            {
                sum = numbers[i] + numbers[j];
                if(intL.IndexOf(sum) == -1)
                {
                    intL.Add(sum);
                }
            }
        }
        int[] answer = intL.ToArray();
        Array.Sort(answer);
        return answer;
    }
}