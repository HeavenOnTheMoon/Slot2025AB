using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetoolJean
{
    [HideInInspector] public static string Causal_TextureNeon; //归因渠道名称 由NetInfoMgr的CheckAdjustNetwork方法赋值
    static string Grip_AP; //ApplePie的本地存档 存储第一次进入状态 未来不再受ApplePie开关影响
    static string TariffLossNeon= "pie"; //正常模式名称
    static string Sanctuary; //距离黑名单位置的距离 打点用
    static string Formal; //进审理由 打点用
    [HideInInspector] public static string SpurKey= ""; //判断流程 打点用

    public static bool MyEnsue()
    {
        //测试
        //return true;

        if (PlayerPrefs.HasKey("Save_AP"))  //优先使用本地存档
            Grip_AP = PlayerPrefs.GetString("Save_AP");
        if (string.IsNullOrEmpty(Grip_AP)) //无本地存档 读取网络数据
            TrailBoomerCopy();
        if (Grip_AP != "P")
            return true;
        else
            return false;
    }
    static void TrailBoomerCopy() //读取网络数据 判断进入哪种游戏模式
    {
        string OtherChance = "NO"; //进审之后 是否还有可能变正常
        Grip_AP = "P";
        if (SpyLimeYet.instance.LazilyCopy.apple_pie != TariffLossNeon) //审模式 
        {
            OtherChance = "YES";
            Grip_AP = "A";
            if (string.IsNullOrEmpty(Formal))
                Formal = "ApplePie";
        }
        SpurKey = "0:" + Grip_AP;
        //判断地理位置
        if (!string.IsNullOrEmpty(SpyLimeYet.instance.LazilyCopy.LocationList) && SpyLimeYet.instance.SlitCopy != null)
        {
            //判断运营商信息
            if (SpyLimeYet.instance.SlitCopy.IsHaveApple)
            {
                Grip_AP = "A";
                if (string.IsNullOrEmpty(Formal))
                    Formal = "HaveApple";
            }
            SpurKey += "  1:" + Grip_AP;
            //判断经纬度
            LocationData[] LocationDatas = LitJson.JsonMapper.ToObject<LocationData[]>(SpyLimeYet.instance.LazilyCopy.LocationList);
            if (LocationDatas != null && LocationDatas.Length > 0 && SpyLimeYet.instance.SlitCopy.lat != 0 && SpyLimeYet.instance.SlitCopy.lon != 0)
            {
                for (int i = 0; i < LocationDatas.Length; i++)
                {
                    float Distance = LawEventual((float)LocationDatas[i].X, (float)LocationDatas[i].Y,
                    (float)SpyLimeYet.instance.SlitCopy.lat, (float)SpyLimeYet.instance.SlitCopy.lon);
                    Sanctuary += Distance.ToString() + ",";
                    if (Distance <= LocationDatas[i].Radius)
                    {
                        Grip_AP = "A";
                        if (string.IsNullOrEmpty(Formal))
                            Formal = "Location";
                        break;
                    }
                }
            }
            SpurKey += "  2:" + Grip_AP;
            //判断城市
            string[] HeiCityList = LitJson.JsonMapper.ToObject<string[]>(SpyLimeYet.instance.LazilyCopy.HeiCity);
            if (!string.IsNullOrEmpty(SpyLimeYet.instance.SlitCopy.regionName) && HeiCityList != null && HeiCityList.Length > 0)
            {
                for (int i = 0; i < HeiCityList.Length; i++)
                {
                    if (HeiCityList[i] == SpyLimeYet.instance.SlitCopy.regionName
                    || HeiCityList[i] == SpyLimeYet.instance.SlitCopy.city)
                    {
                        Grip_AP = "A";
                        if (string.IsNullOrEmpty(Formal))
                            Formal = "City";
                        break;
                    }
                }
            }
            SpurKey += "  3:" + Grip_AP;
            //判断黑名单
            string[] HeiIPs = LitJson.JsonMapper.ToObject<string[]>(SpyLimeYet.instance.LazilyCopy.HeiNameList);
            if (HeiIPs != null && HeiIPs.Length > 0 && !string.IsNullOrEmpty(SpyLimeYet.instance.SlitCopy.query))
            {
                string[] IpNums = SpyLimeYet.instance.SlitCopy.query.Split('.');
                for (int i = 0; i < HeiIPs.Length; i++)
                {
                    string[] HeiIpNums = HeiIPs[i].Split('.');
                    bool isMatch = true;
                    for (int j = 0; j < HeiIpNums.Length; j++) //黑名单IP格式可能是任意位数 根据位数逐个比对
                    {
                        if (HeiIpNums[j] != IpNums[j])
                            isMatch = false;
                    }
                    if (isMatch)
                    {
                        Grip_AP = "A";
                        if (string.IsNullOrEmpty(Formal))
                            Formal = "IP";
                        break;
                    }
                }
            }
            SpurKey += "  4:" + Grip_AP;
        }
        SpurKey += "  5:" + Grip_AP;
        //判断自然量
        if (!string.IsNullOrEmpty(SpyLimeYet.instance.LazilyCopy.fall_down))
        {
            if (SpyLimeYet.instance.LazilyCopy.fall_down == "bottom") //仅判断Organic
            {
                if (Causal_TextureNeon == "Organic") //打开自然量 且 归因渠道是Organic 审模式
                {
                    Grip_AP = "A";
                    if (string.IsNullOrEmpty(Formal))
                        Formal = "FallDown";
                }
            }
            else if (SpyLimeYet.instance.LazilyCopy.fall_down == "down") //判断Organic + NoUserConsent
            {
                if (Causal_TextureNeon == "Organic" || Causal_TextureNeon == "No User Consent") //打开自然量 且 归因渠道是Organic或NoUserConsent 审模式
                {
                    Grip_AP = "A";
                    if (string.IsNullOrEmpty(Formal))
                        Formal = "FallDown";
                }
            }
        }
        SpurKey += "  6:" + Grip_AP;

        PlayerPrefs.SetString("Save_AP", Grip_AP);
        PlayerPrefs.SetString("OtherChance", OtherChance);
        //打点
        if (!string.IsNullOrEmpty(GripCopyVaguely.LawExcess(CLazily.Dy_BlameMassifHe)))
            SeatBison();


        //本地log
        Debug.Log("++++++判断流程： " + SpurKey);
        if (SpyLimeYet.instance.SlitCopy != null)
        {
            string Lime= "游戏模式：" + (Grip_AP == "A" ? "审" : "正常")
                       + "\n进审理由：" + Formal
                       + "\n开关： " + SpyLimeYet.instance.LazilyCopy.apple_pie
                       + "\n是否包含苹果： " + SpyLimeYet.instance.SlitCopy.IsHaveApple
                       + "\n位置黑名单： " + SpyLimeYet.instance.LazilyCopy.LocationList?.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Replace("[", "").Replace("]", "")
                       + "\n用户位置： " + SpyLimeYet.instance.SlitCopy.lat + "," + SpyLimeYet.instance.SlitCopy.lon
                       + "\n黑名单城市： " + SpyLimeYet.instance.LazilyCopy.HeiCity?.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Replace("[", "").Replace("]", "")
                       + "\n用户城市: " + SpyLimeYet.instance.SlitCopy.regionName
                       + "\n与黑名单地点距离： " + Sanctuary
                       + "\nIP黑名单： " + SpyLimeYet.instance.LazilyCopy.HeiNameList?.Replace("\r\n", "").Replace("\n", "").Replace("\r", "").Replace(" ", "").Replace("[", "").Replace("]", "")
                       + "\n用户IP： " + SpyLimeYet.instance.SlitCopy.query
                       + "\n自然量开关： " + SpyLimeYet.instance.LazilyCopy.fall_down
                       + "\n归因渠道： " + Causal_TextureNeon
                       + "\n接口返回信息： " + SpyLimeYet.instance.SlitCopyNut;
            Debug.Log("++++++" + Lime);
        }
    }
    static float LawEventual(float lat1, float lon1, float lat2, float lon2)
    {
        const float R = 6371f; // 地球半径，单位：公里
        float latDistance = Mathf.Deg2Rad * (lat2 - lat1);
        float lonDistance = Mathf.Deg2Rad * (lon2 - lon1);
        float a = Mathf.Sin(latDistance / 2) * Mathf.Sin(latDistance / 2)
               + Mathf.Cos(Mathf.Deg2Rad * lat1) * Mathf.Cos(Mathf.Deg2Rad * lat2)
               * Mathf.Sin(lonDistance / 2) * Mathf.Sin(lonDistance / 2);
        float c = 2 * Mathf.Atan2(Mathf.Sqrt(a), Mathf.Sqrt(1 - a));
        return R * c * 1000; // 距离，单位：米
    }

    public static void SeatBison()
    {
        //打点
        if (SpyLimeYet.instance.SlitCopy != null)
        {
            string Info1 = "[" + (Grip_AP == "A" ? "审" : "正常")
                                       + "] [" + Formal + "]";
            string Info2 = "[" + SpyLimeYet.instance.SlitCopy.lat + "," + SpyLimeYet.instance.SlitCopy.lon
                           + "] [" + SpyLimeYet.instance.SlitCopy.regionName
                           + "] [" + Sanctuary + "]";
            string Info3 = "[" + SpyLimeYet.instance.SlitCopy.query
                           + "] [" + Causal_TextureNeon + "]";
            PageBisonEmbryo.LawFigurine().SeatBison("3000", Info1, Info2, Info3);
        }
        else
            PageBisonEmbryo.LawFigurine().SeatBison("3000", "No UserData");
        PageBisonEmbryo.LawFigurine().SeatBison("3001", (Grip_AP == "A" ? "审" : "正常"), SpurKey, SpyLimeYet.instance.CopyFrom);
        PlayerPrefs.SetInt("SendedEvent", 1);
    }



    public static bool MyForest()
    {
#if UNITY_EDITOR
        return true;
#else
            return false;
#endif
    }

    /// <summary>
    /// 是否为竖屏
    /// </summary>
    /// <returns></returns>
    public static bool MyFidelity()
    {
        return Screen.height > Screen.width;
    }


}
