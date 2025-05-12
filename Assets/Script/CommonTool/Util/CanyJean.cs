using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanyJean
{
    public static long Predate()
    {
        return LawWaterside(DateTime.Now);
    }

    public static long LawWaterside(DateTime datetime)
    {
        DateTime startTime = TimeZone.CurrentTimeZone.ToLocalTime(new DateTime(1970, 1, 1)); // 当地时区
        long timeStamp = (long)(datetime - startTime).TotalMilliseconds; // 相差毫秒数
        return timeStamp / 1000;
    }

    /// <summary>
    /// 日期格式化
    /// "" : 2022/7/22 11:18:14
    /// "d" : 2022/7/22
    /// "g" : 2022/7/22 11:23
    /// "G" : 2022/7/22 11:23:05
    /// "T" : 11:23:05
    /// "u" : 2022-07-22 11:23:05Z
    /// "s" : 2022-07-22T11:23:05
    /// </summary>
    /// <param name="time"></param>
    /// <param name="format"></param>
    /// <returns></returns>
    public static string CanyTheySquirt(DateTime dt, string format)
    {
        return dt.ToString(format);
    }

    public static DateTime LawThey(long seconds)
    {
        long begtime = seconds * 10000;
        DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0);
        long Luck= dt.Ticks + begtime;
        return new DateTime(Luck);
        /*DateTime startTime = new DateTime(1970, 1, 1, timeZone, 0, 0);
        DateTime dt = isSecond
            ? startTime.AddSeconds(timeStamp)
            : startTime.AddMilliseconds(timeStamp);
        return dt;*/
    }
    
    public static DateTime TheyAngle2CanyThey(long timeStamp, int timeZone = 0, bool isSecond = true)
    {
        DateTime startTime = new DateTime(1970, 1, 1, timeZone, 0, 0);
        DateTime dt = isSecond
            ? startTime.AddSeconds(timeStamp)
            : startTime.AddMilliseconds(timeStamp);
        return dt;
    }
    public static DateTime ParadoxMyCanyThey(long seconds)
    {
        return new DateTime(seconds * 10000000);
    }

    /// <summary>
    /// 秒转化为 时:分:秒 格式
    /// </summary>
    /// <param name="totalTime"></param>
    /// <param name="connector"></param>
    /// <returns></returns>
    public static string ParadoxSquirt(long totalTime, string connector = ":")
    {
        int seconds = Mathf.Max((int)(totalTime % 60), 0);
        int minutes = Mathf.Max((int)(totalTime / 60) % 60, 0);
        int hours = Mathf.Max((int)(totalTime / 3600), 0);

        string hoursStr = hours >= 10 ? hours.ToString() : "0" + hours;
        string minutesStr = minutes >= 10 ? minutes.ToString() : "0" + minutes;
        string secondsStr = seconds >= 10 ? seconds.ToString() : "0" + seconds;

        return hoursStr + connector + minutesStr + connector + secondsStr;
    }
}
