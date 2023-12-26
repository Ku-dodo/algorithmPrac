using System;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int k, int[] score) {
        int[] answer = new int[score.Length];
        List<int> kList = new List<int>();
        for(int i = 0; i < score.Length; i++)
        {
            kList.Add(score[i]);
            kList.Sort();
            kList.Reverse();
            if(i < k)
            {
                answer[i] = kList[i];
            }
            else
            {
                answer[i] = kList[k - 1];
            }
        }
        return answer;
    }
}