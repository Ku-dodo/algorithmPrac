using System.Text;

public class Solution {
    public string solution(string s) {
        StringBuilder sb = new StringBuilder();
        int j = 0;
        for(int i = 0; i < s.Length; i++)
        {   
            if(s[i] == 32)
            {
                sb.Append(s[i]);
                j = 0;
                continue;
            }
            if(j % 2 == 0)
            {
                sb.Append(s[i].ToString().ToUpper());
            }
            else if(j % 2 != 0)
            {
                sb.Append(s[i].ToString().ToLower());
            }
            j++;
        }
        
        string answer = "";
        return sb.ToString();
    }
}