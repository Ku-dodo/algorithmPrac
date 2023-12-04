using System.Text;

public class Solution {
    public string solution(string s, int n) {
        StringBuilder sb = new StringBuilder();
        foreach(char c in s)
        {
            if((int)c == 32)
            {
                sb.Append(c);    
            }
            else
            {
                while(n > 26)
                {
                    n -= 26;    
                }
                if(65 <=(int)c && (int)c <= 90)
                {
                    if((int)c + n > 90)
                    {
                        sb.Append((char)((int)c + n - 26));  
                    }
                    else
                    {
                        sb.Append((char)((int)c + n));
                    }
                }
                else if(97 <=(int)c && (int)c <= 122)
                {
                    if((int)c + n > 122)
                    {
                        sb.Append((char)((int)c + n - 26));  
                    }
                    else
                    {
                        sb.Append((char)((int)c + n));
                    }
                }
            }
        }
        string answer = "";
        return sb.ToString();
    }
}