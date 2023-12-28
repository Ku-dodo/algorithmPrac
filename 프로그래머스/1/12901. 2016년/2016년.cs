public class Solution {
    public string solution(int a, int b) {
        string[] dayArr = new string[]{"SUN","MON","TUE","WED","THU","FRI","SAT"};
        int[] startMonthOneDay = new int[] {5, 1, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4};
        
        string answer = dayArr[(startMonthOneDay[a - 1] + b - 1)%dayArr.Length];
        return answer;
    }
}