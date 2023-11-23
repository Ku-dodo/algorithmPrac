using System.Text;
public class Solution {
    public string solution(int n) {
        StringBuilder sb = new StringBuilder();
        string waterMelon = "수박";
        string water = "수";
        if (n % 2 == 0)
        {
            for(int i = 1; i <= n / 2; i++)
            {
                sb.Append(waterMelon);
            }
        }
        else
        {
            for(int i = 1; i <= n / 2; i++)
            {
                sb.Append(waterMelon);
            }
            sb.Append(water);
        }
        return sb.ToString();
    }
}