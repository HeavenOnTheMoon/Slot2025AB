using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagicGameUtil
{
    /// <summary>
    /// 获取multi系数
    /// </summary>
    /// <returns></returns>
    private static double GetMulti(RewardType type, double cumulative, MultiGroup[] multiGroup)
    {
        foreach (MultiGroup item in multiGroup)
        {
            if (item.max > cumulative)
            {
                if (type == RewardType.Cash)
                {
                    float random = Random.Range((float)SpyLimeYet.instance.WoolCopy.cash_random[0], (float)SpyLimeYet.instance.WoolCopy.cash_random[1]);
                    return item.multi * (1 + random);
                }
                else
                {
                    return item.multi;
                }
            }
        }
        return 1;
    }

    public static double GetGoldMulti()
    {
        return GetMulti(RewardType.Gold, GripCopyVaguely.LawSummer(CLazily.Dy_SerigraphyVineHave), SpyLimeYet.instance.WoolCopy.gold_group);
    }

    public static double GetCashMulti()
    {
        var value = GetMulti(RewardType.Cash, GripCopyVaguely.LawSummer(CLazily.Dy_SerigraphyBloom), SpyLimeYet.instance.WoolCopy.cash_group);
        GripCopyVaguely.MadSummer(CLazily.Dy_ReapHomeWhale, value);
        return value;
    }
    public static double GetAmazonMulti()
    {
        return GetMulti(RewardType.Amazon, GripCopyVaguely.LawSummer(CLazily.Dy_SerigraphySteppe), SpyLimeYet.instance.WoolCopy.amazon_group);
    }
}


/// <summary>
/// 奖励类型
/// </summary>
public enum RewardType { Gold, Cash, Amazon }
