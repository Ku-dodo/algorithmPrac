using System;
using System.Collections.Generic;

public class Solution
{
    public Queue<Pos> q = new Queue<Pos>();

    public struct Pos
    {
        public int x, y, moveCount;
    }

    public int solution(string[] board)
    {
        Pos pos = new Pos();
        bool[,] BoardVisit = new bool[board.Length, board[0].Length];

        for (int i = 0; i < board.Length; i++)
        {
            if (board[i].IndexOf('R') != -1)
            {
                pos.x = board[i].IndexOf('R');
                pos.y = i;
                q.Enqueue(pos);
                BoardVisit[pos.y, pos.x] = true;
                break;
            }
        }

        int[] y = { -1, 1, 0, 0 };
        int[] x = { 0, 0, -1, 1 };

        while (q.Count > 0)
        {
            Pos currPos = q.Dequeue();

            if (board[currPos.y][currPos.x] == 'G')
            {
                return currPos.moveCount;
            }

            for (int i = 0; i < 4; i++)
            {
                int nextY = currPos.y;
                int nextX = currPos.x;

                while (true)
                {
                    int tempY = nextY + y[i];
                    int tempX = nextX + x[i];

                    if (tempY < 0 || tempY >= board.Length || tempX < 0 || tempX >= board[0].Length || board[tempY][tempX] == 'D')
                    {
                        break;
                    }

                    nextY = tempY;
                    nextX = tempX;
                }

                if (!BoardVisit[nextY, nextX])
                {
                    BoardVisit[nextY, nextX] = true;
                    q.Enqueue(new Pos {y = nextY, x = nextX, moveCount = currPos.moveCount + 1 }); ;
                }
            }
        }

        return -1;
    }
}