using System;
using System.Collections.Generic;

public class Solution
{
    public struct Mem
    {
        public int price, inTime;
        public Mem (int price, int inTime)
        {
            this.price = price;
            this.inTime = inTime;
        }
    }
    public int[] solution(int[] prices)
    {
        int[] answer = new int[prices.Length];
        Stack<Mem> pStack = new Stack<Mem>();
        for (int i = 0; i < prices.Length; i++)
        {
            Mem curP = new Mem(price : prices[i], inTime : i);

            if(pStack.Count == 0)
            {
                pStack.Push(curP);
                continue;
            }

            Mem preP = pStack.Pop();
            
            while(preP.price > curP.price)
            {
                answer[preP.inTime] = curP.inTime - preP.inTime;
                if(pStack.Count == 0)
                {
                    break;
                }
                preP = pStack.Pop();
            }

            if (preP.price <= curP.price)
            {
                pStack.Push(preP);
            }

            pStack.Push(curP);
        }

        while(pStack.Count > 0)
        {
            Mem m = pStack.Pop();
            answer[m.inTime] = (prices.Length - 1) - m.inTime;
        }

        return answer;
    }
}