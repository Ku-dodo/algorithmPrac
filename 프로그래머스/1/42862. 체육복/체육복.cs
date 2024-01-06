using System;
using System.Linq;

public class Solution {
    public int solution(int n, int[] lost, int[] reserve) {
        Array.Sort(lost);
        Array.Sort(reserve);
        
        int[] filterLost = lost.Except(reserve).ToArray();
        int[] filterReserve = reserve.Except(lost).ToArray();
        
        int answer = n - filterLost.Length;
        
        bool[] haveReserve = new bool[n];
        foreach(int i in filterReserve)
        {
            haveReserve[i - 1] = true;
        }
        foreach(int i in filterLost)
        {
            if(i - 2 >= 0  && haveReserve[i - 2] == true)
            {
                haveReserve[i - 2] = false;
                answer++;
            }
            else if(i < haveReserve.Length && haveReserve[i] == true)
            {
                haveReserve[i] = false;
                answer++;
            }
        }
        return answer;
    }
}