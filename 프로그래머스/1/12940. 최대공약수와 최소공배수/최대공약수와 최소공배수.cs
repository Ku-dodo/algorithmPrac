public class Solution {
    public int[] solution(int n, int m) {
        int[] answer = new int[2];
        int a = n;
        int b = m;
        int r = 0;
        
        //n이 항상 더 크게 맞춰주기 위해서
        if (a < b)
        {
            int temp = a;
            a = b;
            b = temp;
        }
        //유클리드 호제법
        while (a % b != 0)
        {
            r = a % b;
            a = b;
            b = r;
        }
        answer[0] = b;
        
        answer[1] = n * m / b;
        
        return answer;
    }
}