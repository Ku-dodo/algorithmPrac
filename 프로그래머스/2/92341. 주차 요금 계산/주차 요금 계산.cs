using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] fees, string[] records)
    {
        SortedDictionary<string, timeMemory> rc = new SortedDictionary<string, timeMemory>();

        foreach (var r in records)
        {
            string[] rArray = r.Split();
            if (!rc.ContainsKey(rArray[1]))
                rc.Add(rArray[1], new timeMemory());

            int nowTime = calMin(rArray[0]);
            rc[rArray[1]].inputTime(calMin(rArray[0]));
        }


        List<int> list = new List<int>();

        foreach (var d in rc.Values) 
        {
            if (d.isParking)
                d.inputTime(1439);

            list.Add(calFee(fees, d.times));
        }

        return list.ToArray();
    }
    
    public int calMin(string s)
    {   
        string[] a = s.Split(':');
        return int.Parse(a[0]) * 60 + int.Parse(a[1]); 
    }
    public int calFee(int[] i, int time)
    {
        int a = 0;
        if(time <= i[0])
            a = i[1];
        else
            a = i[1] + (int)MathF.Ceiling((float)(time - i[0]) / i[2]) * i[3];
            return a;
    }

}

public class timeMemory
{
    public int recordTime = 0;
    public int times = 0;
    public bool isParking = false;

    public void inputTime(int a)
    {
        if (isParking)
        {
            times += a - recordTime;
            recordTime = 0;
        }
        else
        {
            recordTime = a;
        }
        isParking = !isParking;
    }
}