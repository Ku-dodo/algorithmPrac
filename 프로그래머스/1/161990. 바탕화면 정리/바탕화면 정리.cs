using System;

public class Solution
{
    public int[] solution(string[] wallpaper)
    {
        int[] answer = new int[] { wallpaper.Length, wallpaper[0].Length, 0, 0 }; // minY minX, max Y max X
        for (int y = 0; y < wallpaper.Length; y++)
        {
            for (int x = 0; x < wallpaper[y].Length; x++)
            {
                if (wallpaper[y][x] == '#')
                {
                    if (answer[0] > y) answer[0] = y;
                    if (answer[1] > x) answer[1] = x;
                    if (answer[2] < y) answer[2] = y;
                    if (answer[3] < x) answer[3] = x;
                }
            }
        }
        answer[2]++;
        answer[3]++;
        return answer;
    }
}