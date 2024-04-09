using System;

public class Solution {
    public bool solution(string s) {
        
        int LR = 0;
        bool answer = true;
        
        for(int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(') LR++;
            else LR--;
            
            if (LR < 0) return false;
        }

        return LR == 0;
    }
}