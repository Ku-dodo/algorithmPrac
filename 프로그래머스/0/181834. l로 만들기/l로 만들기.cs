using System;
using System.Text;

public class Solution {
    public string solution(string myString) {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < myString.Length; i++){
            if(myString[i] <= 'l'){
                sb.Append('l');
            }
            else{
                sb.Append(myString[i]);
            }
        }
        
        return sb.ToString();
    }
}