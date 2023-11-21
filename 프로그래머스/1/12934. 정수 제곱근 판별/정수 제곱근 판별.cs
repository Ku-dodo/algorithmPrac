using System;
public class Solution {
    public long solution(long n) {
        return (int)Math.Sqrt(n) == Math.Sqrt(n) ? (long)Math.Pow((Math.Sqrt(n) + 1), 2) : -1;
    }
}