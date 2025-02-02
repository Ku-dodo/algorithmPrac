using System;
using System.Text;

class Solution
{
    public int solution(int n)
    {
        int c = n + 1;
        while (oneCounter(n) != oneCounter(c))
        {
            c++;
        }
        return c;
    }

    public int oneCounter(int a)
    {
        int count = 0;
        while(a > 0)
        {
            count += a & 1;
            a >>= 1;
        }
        return count;
    }
}