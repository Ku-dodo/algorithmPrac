using System;

class Solution
{
    public int solution(int n)
    {
        int answer = 1;
        
        while (n != 1){
            if((n & 1) == 1){
                n -= 1;
                answer++;
            }
            else{
                n = n / 2;
            }
        }

        return answer;
    }
}