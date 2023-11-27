public class Solution {
    public bool solution(string s) {
        bool answer = true;
        if (s.Length !=4 && s.Length != 6)
        {
            answer = false;
        }
        
        for (int i = 0; i < s.Length; i++)
        {   

            if ((int)s[i] > 57 || (int)s[i] < 48)
            {
                answer = false;
                break;
            }
        }
        return answer;
    }
}