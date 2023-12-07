using System;
using System.Collections.Generic;

public class Solution {
    public int solution(string t, string p) {
        int answer = 0;
        long pNum = long.Parse(p);
        int pLeng = p.Length;
        List<long> numList = new List<long>();
        for(int i = 0; i <= t.Length - pLeng; i++)
        {
            numList.Add(long.Parse(t.Substring(i,pLeng)));
        }
        foreach(long item in numList)
        {
            if(item <= pNum)
            {
                answer++;
            }
        }
        return answer;
    }
}