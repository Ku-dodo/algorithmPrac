using System;

public class Solution {
    public int solution(int left, int right) {      
        int answer = 0;
        while (left <= right)
        {
            int divisorNum = 0;
            for(int i = 1; i <= left; i++)
            {
                if(left % i == 0)
                {
                    divisorNum++; 
                }    
            }
            if(divisorNum % 2 == 0)
            {
                answer += left;
            }
            else
            {
                answer -= left;    
            }
            left++;
        }
        return answer;
    }
}