using System;
using System.Text;

public class Solution {
    public string solution(int[] food) {
        StringBuilder sb = new StringBuilder();
        for (int i = 1; i < food.Length; i++)
        {
            for(int j = 1; j <= food[i] / 2; j++)
            {
                sb.Append(i.ToString());
            }
        }
        sb.Append("0");
        for(int i = food.Length - 1; i >= 1; i--)
        {
            for(int j = 1; j <= food[i] / 2; j++)
            {
                sb.Append(i.ToString());
            }
        }
        string answer = sb.ToString();
        return answer;
    }
}