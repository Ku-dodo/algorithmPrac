public class Solution {
    public string solution(string s) {
        return s.Length % 2 == 1 ? s[s.Length / 2].ToString() : s.Substring(s.Length / 2 - 1, 2);
    }
}