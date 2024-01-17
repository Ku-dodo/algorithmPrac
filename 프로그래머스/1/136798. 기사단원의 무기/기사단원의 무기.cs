using System;

public class Solution {
    public int solution(int number, int limit, int power) {
        int[] arr = new int[number];
        for(int i = 1; i <= number; i++)
        {
            int a = 0;
            for(int j = 1; Math.Pow(j, 2) <= i; j++){
                if(i == Math.Pow(j, 2)){
                    a += 1;
                }
                else if(i % j == 0){
                    a += 2;
                }
            }
            arr[i - 1] = a;
        }
        int answer = 0;
        foreach(int i in arr)
        {
            if(i > limit){
                answer += power;
            }
            else{
                answer += i;
            }
        }
        return answer;
    }
}