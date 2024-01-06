using System;

public class Solution {
    public string solution(string[] cards1, string[] cards2, string[] goal) {
        int useCard1Index = 0;
        int useCard2Index = 0;
        for(int i = 0; i < goal.Length; i++)
        {
            if(useCard1Index < cards1.Length && cards1[useCard1Index] == goal[i])
            {
                useCard1Index++;
            }
            else if(useCard2Index < cards2.Length && cards2[useCard2Index] == goal[i])
            {
                useCard2Index++;
            }
            else
            {
                return "No";
            }
        }
        return "Yes";
    }
}