using System;

class Solution
{
    public int solution(int[] nums)
    {
        bool[] PrimeArray = new bool[3001];
        
        int PrimeLength = PrimeArray.Length - 1;
	    for (int i = 2; i <= PrimeLength; i++)
        {
            PrimeArray[i] = true;
        }
	        
        
        for (int i = 2; i*i <= PrimeLength; i++)
        {
            if (PrimeArray[i])
            {
                for(int j = i * i; j <= PrimeLength; j += i)
                {
                    PrimeArray[j] = false; 
                }
            }
        }

        int answer = 0;
        
        for(int i = 0; i < nums.Length; i++)
        {
            for(int j = i + 1; j < nums.Length ; j++)
            {
                for(int n = j + 1; n < nums.Length; n++)
                {
                    if(PrimeArray[nums[i] + nums[j] + nums[n]] == true)
                    {
                        answer++;
                    }
                }
            }
        }
        return answer;
        
    }
}