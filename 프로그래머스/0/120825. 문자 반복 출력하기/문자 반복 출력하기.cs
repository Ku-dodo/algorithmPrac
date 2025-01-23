using System;
using System.Text;

public class Solution {
    public string solution(string my_string, int n) {
        StringBuilder sb = new StringBuilder();
        
        for(int i = 0; i < my_string.Length; i++){
            for(int a = 0; a < n; a++){
                sb.Append(my_string[i]);
            }
        }
        
        return sb.ToString();
    }
}