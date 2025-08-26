using System;
using System.Collections.Generic;

class Solution
{
    public struct Pos
    {
        public int y, x, moveCount;

        public Pos(int y, int x, int moveCount)
        {
            this.y = y;
            this.x = x;
            this.moveCount = moveCount;
        }
    }

    public int solution(int[,] maps)
    {
        Queue<Pos> posQueue = new Queue<Pos>();
        bool[,] visitPos = new bool[maps.GetLength(0), maps.GetLength(1)];

        posQueue.Enqueue(new Pos(0, 0, 1));
        visitPos[0, 0] = true;
        int[] y = { -1, 1, 0, 0 };
        int[] x = { 0, 0, -1, 1 };

        while (posQueue.Count > 0)
        {
            Pos p = posQueue.Dequeue();
            for (int i = 0; i < 4; i++)
            {
                int tempY = p.y + y[i];
                int tempX = p.x + x[i];

                if (0 > tempY || tempY > maps.GetLength(0) - 1 || 0 > tempX || tempX > maps.GetLength(1) - 1)
                {
                    continue;
                }
                else if (tempY == maps.GetLength(0) - 1 && tempX == maps.GetLength(1) - 1)
                {
                    return p.moveCount + 1;
                }

                if (maps[tempY, tempX] == 1 && visitPos[tempY, tempX] == false)
                {
                    visitPos[tempY, tempX] = true;
                    posQueue.Enqueue(new Pos(y: tempY, x: tempX, moveCount: p.moveCount + 1));
                }
            }
        }

        int answer = -1;
        return answer;
    }
}