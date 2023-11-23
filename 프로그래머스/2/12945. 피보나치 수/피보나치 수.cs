public class Solution {
    public int solution(int n) {
        int num1 = 0;
        int num2 = 1;
        int num3 = 1;
        for(int i = 1; i < n; i++)
        {
            num3 = (num1 + num2) % 1234567;
            num1 = num2;
            num2 = num3;
        }
        int answer = num3;
        return (int)answer;
    }
}