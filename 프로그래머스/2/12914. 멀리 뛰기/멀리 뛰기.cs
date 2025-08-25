public class Solution
{
    public long solution(int n)
    {
        if (n == 1) return 1;
        if (n == 2) return 2;

        long numA = 1;
        long numB = 2;
        long res = 0;

        for(int i = 3; i <= n; i++)
        {
            res = (numA + numB) % 1234567;
            numA = numB;
            numB = res;
        }

        return res;
    }
}