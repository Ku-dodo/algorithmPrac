using System.Collections.Generic;
using System.Linq;
public class Solution {
    public int[] solution(int[] arr) {
        int[] answer;
        if (arr.Length <= 1)
        {
            return new int[] {-1};    
        }
        else
        {
            int min = arr.Min();
            IEnumerable<int> filterArray = from num in arr
                where min != num
                select num;
            answer = filterArray.ToArray();
        }
        
        return answer;
    }
}