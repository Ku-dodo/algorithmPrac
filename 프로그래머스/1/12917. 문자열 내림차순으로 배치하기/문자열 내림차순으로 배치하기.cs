using System;
using System.Linq;

public class Solution {
    public string solution(string s) {
        char[] b = s.ToArray();
        Array.Sort(b);
        Array.Reverse(b);
        string answer = "";
        foreach(char c in b)
        {
            answer += c;   
        }
        return answer;
    }
}