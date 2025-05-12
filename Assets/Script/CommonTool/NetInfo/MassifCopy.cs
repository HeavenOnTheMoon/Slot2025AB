using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//登录服务器返回数据
public class RootData 
{
    public int code { get; set; }
    public string msg { get; set; }
    public MassifCopy data { get; set; }
}
//用户登录信息
public class ServerUserData
{
    public int code { get; set; }
    public string msg { get; set; }
    public int data { get; set; }
}
//服务器的数据
public class MassifCopy
{
    public string init { get; set; }
    public string init_br { get; set; }
    public string init_jp { get; set; }
    public string init_us { get; set; }
    public string init_ru { get; set; }

    public string slotInfo { get; set; }
    public string gameInfo { get; set; }

    public string version { get; set; }

    public string apple_pie { get; set; }
    public string inter_b2f_count { get; set; }
    public string inter_b2f_freq { get; set; }
    public string ad_fail_interval { get; set; }
    public string ad_limit_interval { get; set; }
    public string ad_limit_hour { get; set; }
    public string ad_limit { get; set; }
    public string inter_freq { get; set; }
    public string inter_delay { get; set; }
    public string inter_count { get; set; }
    public string relax_interval { get; set; }
    public string trial_MaxNum { get; set; }
    public string nextlevel_interval { get; set; }
    public string adjust_init_rate_act { get; set; }
    public string adjust_init_act_position { get; set; }
    public string adjust_init_adrevenue { get; set; }

    public string soho_shop { get; set; }
    public string soho_shop_br { get; set; }
    public string soho_shop_jp { get; set; }
    public string soho_shop_us { get; set; }
    public string soho_shop_ru { get; set; }
    public string fall_down { get; set; }
    public string HeiNameList { get; set; } //IP黑名单列表
    public string LocationList { get; set; } //黑位置列表
    public string HeiCity { get; set; } //城市黑名单列表

}
public class Init
{
    public List<SlotItem> slot_group { get; set; }

    public double[] cash_random { get; set; }
    public MultiGroup[] cash_group { get; set; }
    public MultiGroup[] gold_group { get; set; }
    public MultiGroup[] amazon_group { get; set; }
    
    
    
}

public class GameInfo
{
    public WandOrRingInfo WandInfo;
    public WandOrRingInfo RingInfo;
    public BottleInfo BottleInfo;
    public FlyInfo FlyInfo;
    public CoinPigInfo CoinPigInfo;
    public SpinRecoverTime SpinRecoverTime;
    public int DailyCashCount;
}


public class SlotInfo
{
    //Todo 暂时存放
    public List<SpecialSpin> specialSpin;
    public List<SpecialSpin> dailyspecialSpin;
    public FreeSpinWeight freeSpinWeight;
    public DailySpinCompensation dailySpinCompensation;
}

public class SlotItem
{
    public int multi { get; set; }
    public int weight { get; set; }
}

public class MultiGroup
{
    public int max { get; set; }
    public int multi { get; set; }
}

public class TimeStamp
{
    public int code { get; set; }
    public string msg { get; set; }
    public int data { get; set; }
}

public class WandOrRingInfo
{
    public List <int > Weight { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string CashCoefficient { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string ACardCoefficient { get; set; }
}

public class BottleInfo
{
    /// <summary>
    /// 
    /// </summary>
    public List <int > Weight { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string CashCoefficient { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string ACardCoefficient { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public string BigCashCoefficient { get; set; }
    
    public int BottleCount { get; set; }
}

public class FlyInfo
{
    public int FlyTime;
    public string CashCoefficient;
}

public class CoinPigInfo
{
    public int MinCash;
    public int OnceAddCash;
    public int AddLevelCount;
    public int MaxLevel;
    public int OpenSpinCount;
    public int OpenPigCoinValue;
    public int MaxOpenByCoin;
}

public class SpinRecoverTime
{
    public int MaxSpinCount;
    public int RecoverTime;
}

public class UserRootData
{
    public int code { get; set; }
    public string msg { get; set; }
    public string data { get; set; }
}

public class LocationData
{
    public double X;
    public double Y;
    public double Radius;
}

public class UserInfoData
{
    public double lat;
    public double lon;
    public string query; //ip地址
    public string regionName; //地区名称
    public string city; //城市名称
    public bool IsHaveApple; //是否有苹果
}

