public class Solution
{
    public int[] solution(int[] num_list)
    {
        int a = 0;
        int b = 0;
        foreach (int i in num_list)
        {
            if((i & 1) != 1)
                a++;
            else
                b++;
        }
        return new int[] {a, b};
    }
}