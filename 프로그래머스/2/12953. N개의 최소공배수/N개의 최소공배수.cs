using System;

public class Solution
{
    public int solution(int[] arr)
    {
        Array.Sort(arr);
        int multiple = 1;

        while (true)
        {
            bool bb = true;
            int a = arr[arr.Length - 1] * multiple;
            foreach (int i in arr)
            {
                if (a % i != 0)
                {
                    bb = false;
                    break;
                }
            }
            if (!bb)
                multiple++;
            else
                break;
        }

        return arr[arr.Length - 1] * multiple;
    }
}