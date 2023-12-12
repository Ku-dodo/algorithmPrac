using System;

public class Solution {
    public string[] solution(string[] strings, int n) {
        for(int i = 0; i < strings.Length; i++)
        {
            for(int j = 1; i + j < strings.Length; j++)
            {
                if((int)strings[i][n] > (int)strings[i + j][n])
                {
                    string temp = strings[i];
                    strings[i] = strings [i + j];
                    strings[i + j] = temp;
                }
                else if(((int)strings[i][n] == (int)strings[i + j][n]))
                {
                    if(string.Compare(strings[i], strings[i + j]) == 1)
                    {
                        string temp = strings[i];
                        strings[i] = strings [i + j];
                        strings[i + j] = temp;
                    }
                }
            }
        }
        //string[] answer = new string[] {};
        return strings;
    }
}