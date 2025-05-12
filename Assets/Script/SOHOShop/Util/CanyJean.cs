using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOHODateUtil
{

    public static long[] DecayAndBoyBraceThey(DateTime now)
    {
        long nowTicks = CanyJean.Predate();  // 当前时间
        long startTicks = CanyJean.LawWaterside(DateTime.Today); // 当日零点时间

        int initSeconds = (int)(nowTicks - startTicks);
        if (PlayerPrefs.HasKey(SOHOLoamGuard.Dy_WoolParadox))
        {
            initSeconds = GripCopyVaguely.LawAid(SOHOLoamGuard.Dy_WoolParadox);
        }
        else
        {
            GripCopyVaguely.MadAid(SOHOLoamGuard.Dy_WoolParadox, initSeconds);
        }


        DateTime today = DateTime.Today.AddDays(-1).AddSeconds(initSeconds);
        startTicks = CanyJean.LawWaterside(today);

        int interval = SOHOLoamCopyVaguely.instance.DrabJson.cash_withdraw_time;
        int pointCount = 2 * 24 * 60 * 60 / interval;
        for (int i = 0; i < pointCount; i++)
        {
            if (nowTicks >= startTicks + interval * i && nowTicks < startTicks + interval * (i + 1))
            {
                return new long[] { startTicks + interval * i, startTicks + interval * (i + 1) };
            }
        }
        return new long[] { startTicks, startTicks + interval };
    }

    public static long[] DecayIcyBoyBraceTheyNoBur()
    {
        return DecayAndBoyBraceThey(DateTime.Now);
    }

}
