using System;
using System.Collections.Generic;

public class Solution
{
    public int[] solution(int[] fees, string[] records)
    {
        SortedDictionary<string , Recorder> parkRecoder = new SortedDictionary<string , Recorder>();
        foreach (var rec in records)
        {
            string[] recArray = rec.Split(' ');

            if (!parkRecoder.ContainsKey(recArray[1]))
            {
                parkRecoder.Add(recArray[1], new Recorder());
            }

            parkRecoder[recArray[1]].Parking(recArray[0]);
        }


        List<int> answer = new List<int>();
        foreach (var r in parkRecoder.Values)
        {
            if (r.isParking)
            {
                r.Parking("23:59");
            }


            if (r.times <= fees[0] && !r.isParking)
            {
                answer.Add(fees[1]);
            }
            else
            {
                answer.Add(fees[1] + (int)MathF.Ceiling((float)(r.times - fees[0]) / fees[2]) * fees[3]);
            }
        }

        return answer.ToArray();
    }
}

public class Recorder
{
    public int times, parkInTime;
    public bool isParking = false;

    public void Parking(string time)
    {
        if (isParking)
        {
            times += StrToMin(time) - parkInTime;
            isParking = false;
        }
        else
        {
            parkInTime = StrToMin(time);
            isParking=true;
        }
    }

    private int StrToMin(string time)
    {
        string[] s = time.Split(':');
        return int.Parse(s[0]) * 60 + int.Parse(s[1]);
    }
}