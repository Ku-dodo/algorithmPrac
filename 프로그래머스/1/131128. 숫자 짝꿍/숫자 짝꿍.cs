using System;
using System.Text;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public string solution(string X, string Y) {
        
        Dictionary<char, int> charY = new Dictionary<char, int>();
        foreach(var c in Y)
        {
            if(!charY.ContainsKey(c))
            {
                charY.Add(c, 0);
            }
            charY[c]++;
        }
        
        StringBuilder Z = new StringBuilder();
        foreach(var c in X)
        {
            if(charY.ContainsKey(c) && charY[c] > 0)
            {
                Z.Append(c);
                charY[c]--;
            }
        }
        
        string answer = Z.ToString();
        
        if(answer.Length == 0)
        {
            return "-1";
        }
        else if(answer.Replace("0", "").Length == 0)
        {
            return "0";
        }

        return string.Concat(answer.OrderByDescending(ch => ch));

    }
}