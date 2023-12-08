using System;

public class Solution {
    public int solution(string s) {
        string[,] sArr = {{"zero","0"},{"one","1"},{"two","2"},{"three","3"},{"four","4"},{"five","5"},{"six","6"},{"seven","7"},{"eight","8"},{"nine","9"}};
        for(int i = 0; i < sArr.GetLength(0); i++)
        {
            s = s.Replace(sArr[i, 0], sArr [i, 1] );
        }
        return int.Parse(s);
    }
}