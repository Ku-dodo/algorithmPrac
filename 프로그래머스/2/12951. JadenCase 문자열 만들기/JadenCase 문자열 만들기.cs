using System.Text;

public class Solution {
    public string solution(string s) {
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < s.Length; i++)
        {
            if(i == 0)
            {
                if(97 <= (int)s[i] && (int)s[i] <= 122)
                {
                    sb.Append((char)((int)s[i] - 32));
                }
                else
                {
                    sb.Append(s[i]);  
                }
            }
            else if((int)s[i-1] == 32 && 97 <= (int)s[i] && (int)s[i] <= 122)
            {
                sb.Append((char)((int)s[i] - 32));
            }
            else if((int)s[i-1] != 32 && 65 <= (int)s[i] && (int)s[i] <= 90)
            {
                sb.Append((char)((int)s[i] + 32));   
            }
            else
            {
                sb.Append(s[i]);    
            }
        }
        
        return sb.ToString();
    }
}