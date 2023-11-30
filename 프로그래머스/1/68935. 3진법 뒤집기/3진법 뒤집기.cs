using System;

public class Solution {
    public int solution(int n) {
        
        long answer = 0;
        
        while(n > 0){
            long num = 3;
            long s_num = 1;
            long sqrt = 0;
            while (num <= n)
            {
                num *= 3;
                sqrt++;
            }
            num /= 3;
            n -= (int)num;
            
            for (int i = 1; i <= sqrt; i++)
            {
                s_num *= 10;
            }
            
            answer += (long)s_num;
        }
        string str = answer.ToString();

        answer = 0;
        
        for(int i = 0; i < str.Length; i++)
        {
            long num = 3;
            long s_num = 1;
            for(int j = 1; j <= i; j++)
            {
                s_num *= num;
            }
            answer += (s_num * (str[i] - 48));
        }        
        
        
        return (int)answer;
    }
}