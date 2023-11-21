using System;

public class Solution {
    public long solution(long n) {
        string str = n.ToString();
        char [] astr =  new char[str.Length];
        for(int i = 0; i < str.Length; i++)
        {
             astr[i] = str[i];
        }
        Array.Sort(astr);
        Array.Reverse(astr);

        long answer = long.Parse(String.Join("", astr));
        return answer;
    }
}