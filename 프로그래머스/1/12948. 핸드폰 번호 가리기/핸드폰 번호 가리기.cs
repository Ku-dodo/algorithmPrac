using System.Text;
public class Solution {
    public string solution(string phone_number) {
        StringBuilder phone_sb = new StringBuilder();
        for (int i = 0; i < phone_number.Length; i++)
        {
            if (i < phone_number.Length - 4)
            {
                phone_sb.Append('*');
            }
            else
            {
                phone_sb.Append(phone_number[i]); 
            }
        }
        
        return phone_sb.ToString();
    }
}