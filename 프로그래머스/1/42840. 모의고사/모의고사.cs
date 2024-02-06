using System;
using System.Collections.Generic;
using System.Linq;

public class Solution {
    public int[] solution(int[] answers) {
        int[] mathGiveUp1 = new int[] {1, 2, 3, 4, 5};
        int getPoint1 = 0;
        
        int[] mathGiveUp2 = new int[] {2, 1, 2, 3, 2, 4, 2, 5};
        int getPoint2 = 0;
        
        int[] mathGiveUp3 = new int[] {3, 3, 1, 1, 2, 2, 4, 4, 5, 5};
        int getPoint3 = 0;
                
        for(int i = 0; i < answers.Length; i++)
        {
            if(mathGiveUp1[i % mathGiveUp1.Length] == answers[i])
            {
                getPoint1++;
            }
            if(mathGiveUp2[i % mathGiveUp2.Length] == answers[i])
            {
                getPoint2++;
            }
            if(mathGiveUp3[i % mathGiveUp3.Length] == answers[i])
            {
                getPoint3++;
            }
        }
        
        Dictionary<int, int> dic = new Dictionary<int, int>();
        
        if(getPoint1 >= 1)
            dic.Add(1,getPoint1);
        if(getPoint2 >= 1)
            dic.Add(2,getPoint2);
        if(getPoint3 >= 1)
            dic.Add(3,getPoint3);
        
        List<int> answer = new List<int>();
        
        foreach(var item in dic.OrderByDescending(item => item.Value).ToList())
        {
            if(dic.Values.Max() == item.Value)
            {
                answer.Add(item.Key);
            }
        }

        return answer.ToArray();
    }
}