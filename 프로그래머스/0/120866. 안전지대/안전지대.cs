using System.Collections.Generic;

public class Solution
{
    public int solution(int[,] board)
    {
        int answer = 0;
        List<(int y, int x)> adj = new List<(int y, int x)>();

        adj.Add((-1, -1));
        adj.Add((-1, 0));
        adj.Add((-1, 1));
        adj.Add((0, -1));
        adj.Add((0, 1));
        adj.Add((1, -1));
        adj.Add((1, 0));
        adj.Add((1, 1));

        for (int i = 0; i < board.GetLength(0); i++)
        {
            for (int j = 0; j < board.GetLength(1); j++)
            {
                if (board[i, j] != 1)
                {
                    bool isSafe = true;
                    foreach (var p in adj)
                    {
                        if ((0 <= i + p.y && i + p.y < board.GetLength(0)) && (0 <= j + p.x && j + p.x < board.GetLength(1)))
                        {
                            if (board[i + p.y, j + p.x] == 1)
                            {
                                isSafe = false;
                                break;
                            }
                        }
                    }
                    if (isSafe)
                    {
                        answer++;
                    }
                }

            }
        }
        return answer;
    }
}