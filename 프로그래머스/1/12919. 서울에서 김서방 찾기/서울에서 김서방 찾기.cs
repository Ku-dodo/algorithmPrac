using System;

public class Solution {
    public string solution(string[] seoul) {
        string answer = $"김서방은 {Array.IndexOf(seoul, "Kim")}에 있다";
        return answer;
    }
}