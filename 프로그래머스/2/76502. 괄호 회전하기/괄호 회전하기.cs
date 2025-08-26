using System;
using System.Text;
public class Solution
{
    public int solution(string s)
    {
        StringBuilder originSB = new StringBuilder();
        originSB.Append(s);
        int answer = 0;
        do
        {
            char c = originSB[0];
            originSB.Remove(0, 1).Append(c);

            StringBuilder copySB = new StringBuilder();
            copySB.Append(originSB);

            int a = copySB.Length;
            do
            {
                a = copySB.Length;
                copySB.Replace("()", "");
                copySB.Replace("{}", "");
                copySB.Replace("[]", "");

                if(copySB.Length == 0)
                {
                    answer++;
                    break;
                }
            } while (copySB.Length != a);
            
        } while (s != originSB.ToString());

        return answer;
    }
}