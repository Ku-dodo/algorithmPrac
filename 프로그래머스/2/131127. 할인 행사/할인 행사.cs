using System;
using System.Linq;
using System.Collections.Generic;

public class Solution
{
    public int solution(string[] want, int[] number, string[] discount)
    {
        Dictionary<string, int> wants = new Dictionary<string, int>();
        Dictionary<string, int> DisGoods = new Dictionary<string, int>();
        Queue<string> saleQueue = new Queue<string>();
        int goodsCount = 0;
        int answer = 0;
        for (int i = 0; i < want.Length; i++)
        {
            wants.Add(want[i], number[i]);
            goodsCount += number[i];
        }

        for (int i = 0; i < discount.Length; i++)
        {
            if (!DisGoods.ContainsKey(discount[i]))
            {
                DisGoods.Add(discount[i], 0);
            }

            DisGoods[discount[i]]++;
            saleQueue.Enqueue(discount[i]);

            if(i >= goodsCount)
            {
                string s = saleQueue.Dequeue();
                DisGoods[s]--;

                if (DisGoods[s] == 0)
                {
                    DisGoods.Remove(s);
                }
            }

            if(EqualTestDictionary(wants, DisGoods))
            {
                answer++;
            }
        }
        return answer;
    }

    public bool EqualTestDictionary(Dictionary<string,int> a, Dictionary<string,int> b)
    {
        if (a.Count != b.Count)
        {
            return false;
        }

        return a.All(d => b.TryGetValue(d.Key, out var v) && d.Value.Equals(v));
    }
}