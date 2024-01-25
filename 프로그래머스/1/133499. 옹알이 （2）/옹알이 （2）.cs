using System;
using System.Text;

public class Solution {
    public int solution(string[] babbling) {
        string[] talk = {"aya", "ye", "woo", "ma"};
        string[] cantTalk = {"ayaaya", "yeye", "woowoo", "mama"};
        int answer = 0;
        for(int i = 0; i < babbling.Length; i++)
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(babbling[i]);
            
            for(int j = 0; j < talk.Length; j++)
            {
                if(babbling[i].IndexOf(cantTalk[j]) < 0)
                {
                    sb.Replace(talk[j]," ");
                }
            }
            sb.Replace(" ", "");
            if(sb.Length == 0){
                answer++;
            }
            sb.Clear();
        }

        return answer;
    }
}