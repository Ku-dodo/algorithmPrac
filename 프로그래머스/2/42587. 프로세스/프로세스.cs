using System;

public class Solution
{
    public struct P
    {
        public int locate = 0;
        public int pri = 0;
        public P(int locate, int pri)
        {
            this.locate = locate;
            this.pri = pri;
        }
    }

    public int solution(int[] priorities, int location)
    {
        P[] pArray = new P[priorities.Length];
        for (int i = 0; i < priorities.Length; i++)
        {
            pArray[i] = new P(i, priorities[i]);
        }

        pArray = pArray.OrderBy(item => item.pri).ToArray();

        int a = 0;

        for (int i = 0; i < pArray.Length; i++)
        {
            if (pArray[i].locate == location)
            {
                a = i;
                break;
            }
        }
        return a;
    }
}