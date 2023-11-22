using System;
using System.Linq;
using System.Collections.Generic;

public class Solution {
    public int[] solution(int[] arr, int divisor) {
        Array.Sort(arr);
        IEnumerable<int> array = from num in arr
            where num % divisor == 0
            select num;
        int[] answerArray = array.ToArray();
        return answerArray.Length != 0 ? answerArray : new int[] {-1};
    }
}