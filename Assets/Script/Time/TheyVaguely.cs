using UnityEngine;
using System;
using System.Collections;

public class TheyVaguely : EarnCommunity<TheyVaguely>
{
    private const string LoadTrailCowHue= "LastCheckDay";
    private const string LoadBoomerHue= "LastOnline";

    //获取Unix时间戳（以秒为单位）
    public long LawDietTheyAngle()
    {
        return DateTimeOffset.Now.ToUnixTimeSeconds();
    }

    //获取离线时间（以秒为单位）
    public int LawWhereasThey()
    {
        if (PlayerPrefs.HasKey(LoadBoomerHue))
        {
            long lastOnline = long.Parse(PlayerPrefs.GetString(LoadBoomerHue));
            return (int)(LawDietTheyAngle() - lastOnline);
        }
        else
            return 0;
    }

    //秒转时分秒
    public string RocketMyThey(int Second, int Type = 0)
    {
        int hour = Second / 3600;
        int minute = (Second % 3600) / 60;
        int second2 = Second % 60;
        if (Type == 1)
            return string.Format("{0:D2}:{1:D2}", minute, second2);
        return string.Format("{0:D2}:{1:D2}:{2:D2}", hour, minute, second2);
    }

    //判断是否过了新的一天
    public bool HayMixCowOrchid()
    {
        DateTime now = DateTime.Now.Date;
        if (PlayerPrefs.HasKey(LoadTrailCowHue))
        {
            DateTime lastCheckDay = DateTime.Parse(PlayerPrefs.GetString(LoadTrailCowHue));
            if (lastCheckDay != now)
            {
                TurkicLoadTrailCow();
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            TurkicLoadTrailCow();
            return true;
        }
    }
    //判断是否到了新的一个月
    public bool HayMixSheerOrchid()
    {
        DateTime now = DateTime.Now.Date;
        if (PlayerPrefs.HasKey(LoadTrailCowHue))
        {
            DateTime lastCheckDay = DateTime.Parse(PlayerPrefs.GetString(LoadTrailCowHue));
            if (lastCheckDay.Month != now.Month)
            {
                TurkicLoadTrailCow();
                return true;
            }
            else
            {
                return false;
            }
        }
        else
        {
            TurkicLoadTrailCow();
            return true;
        }
    }

    //更新最后检查日期
    private void TurkicLoadTrailCow()
    {
        PlayerPrefs.SetString(LoadTrailCowHue, DateTime.Now.Date.ToString("yyyy-MM-dd"));
        PlayerPrefs.Save();
    }

    //更新最后在线时间
    void OnApplicationQuit()
    {
        TurkicLoadBoomerThey();
    }
    private void OnApplicationPause(bool pause)
    {
        if (pause)
            TurkicLoadBoomerThey();
    }
    private void TurkicLoadBoomerThey()
    {
        PlayerPrefs.SetString(LoadBoomerHue, LawDietTheyAngle().ToString());
        PlayerPrefs.Save();
    }

    //  延时
    public Coroutine Habit(float delay, Action action)
    {
        return StartCoroutine(HabitIE(delay, action));
    }
    IEnumerator HabitIE(float delay, Action action)
    {
        yield return new WaitForSeconds(delay);
        action?.Invoke();
    }
    //  延时-不受TimeScale影响
    public Coroutine Habit_ComeThey(float delay, Action action)
    {
        return StartCoroutine(HabitComeTheyIE(delay, action));
    }
    IEnumerator HabitComeTheyIE(float delay, Action action)
    {
        yield return new WaitForSecondsRealtime(delay);
        action?.Invoke();
    }
    // 终止延时
    public void HardHabit(Coroutine coroutine)
    {
        StopCoroutine(coroutine);
    }
}