using System;

public class Solution {
    public int[] solution(int[] lottos, int[] win_nums) {
        int unknownNum = 0;
        int[] answer = new int[] {0,0};
        foreach(int a in lottos)
        {
            if (a == 0)
            {
                unknownNum++;
            }
            else
            {
                for(int j = 0; j < win_nums.Length; j++)
                {
                    if(a == win_nums[j])
                    {
                        answer[1]++;
                    }
                }
            }
        }
        answer[0] = answer[1] + unknownNum;
        for(int i = 0; i < answer.Length; i++)
        {
            switch(answer[i])
            {
                case 6 :
                    answer[i] = 1;
                    break;
                case 5 :
                    answer[i] = 2;
                    break;
                case 4 :
                    answer[i] = 3;
                    break;
                case 3 :
                    answer[i] = 4;
                    break;
                case 2 :
                    answer[i] = 5;
                    break;
                default:
                    answer[i] = 6;
                    break;
            } 
        }
        return answer;
    }
}