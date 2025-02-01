using System;

public class Solution {
    public int solution(string s) {
        return div(s);
    }
    
    public int div(string s){
        int x = 1;
        int y = 0;
        int index = s.Length - 1;
        
        for (int i = 1; i < s.Length; i++){
            if(s[0] == s[i])
            {
                x++;
            }
            else
            {
                y++;
            }
            
            if(x == y)
            {
                index = i;
                break;
            }
        }
        
        return s == "" ? 0 : 1 + div(s.Substring(index + 1));
        
        
    }
}