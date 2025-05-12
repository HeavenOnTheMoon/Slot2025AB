using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOHOLoamVaguely : MonoBehaviour
{
    public static SOHOLoamVaguely instance;
[UnityEngine.Serialization.FormerlySerializedAs("getCashAction")]
    public Func<double> getHomeGreedy;
[UnityEngine.Serialization.FormerlySerializedAs("getGoldAction")]    public Func<double> JobVineGreedy;
[UnityEngine.Serialization.FormerlySerializedAs("getAmazonAction")]    public Func<double> JobSteppeGreedy;
[UnityEngine.Serialization.FormerlySerializedAs("subCashAction")]    public Action<double> RodHomeGreedy;
[UnityEngine.Serialization.FormerlySerializedAs("subGoldAction")]    public Action<double> RodVineGreedy;
[UnityEngine.Serialization.FormerlySerializedAs("subAmazonAction")]    public Action<double> RodSteppeGreedy;
[UnityEngine.Serialization.FormerlySerializedAs("UI_SelectedBG")]
    public Sprite UI_SynapsisBG;
[UnityEngine.Serialization.FormerlySerializedAs("UI_NotSelectedBG")]    public Sprite UI_YamSynapsisBG;
[UnityEngine.Serialization.FormerlySerializedAs("PaySprites")]    public Sprite[] PryConsult;
[UnityEngine.Serialization.FormerlySerializedAs("Puzzle_Pieces")]    public Sprite[] Seeker_Primal;
[UnityEngine.Serialization.FormerlySerializedAs("Puzzle_Rewards")]    public Sprite[] Seeker_Reverse;
[UnityEngine.Serialization.FormerlySerializedAs("VineSteppeThoughSink")]    public GameObject VineSteppeThoughSink;
[UnityEngine.Serialization.FormerlySerializedAs("RecordItem")]    public GameObject TemperSink;
[UnityEngine.Serialization.FormerlySerializedAs("RedeemGiftItem")]    public GameObject ThoughTollSink;
[UnityEngine.Serialization.FormerlySerializedAs("ThoughSink")]    public GameObject ThoughSink;
[UnityEngine.Serialization.FormerlySerializedAs("AllCardItem")]    public GameObject HimHaleSink;

    private bool BeCider;

    private void Awake()
    {
        instance = this;

        BeCider = false;
    }

    private void OnApplicationPause(bool pause)
    {
        if (!pause && BeCider && SOHOLoamCopyVaguely.instance.DrabJson.cash_withdraw_type == 0)
        {
            // 进入前台，重新开始倒计时
            HomeThoughVaguely.instance.WoolHomeTolerant();
        }
    }

    public void WoolSOHOLoam()
    {
        SOHOLoamCopyVaguely.instance.WoolLoamCopy();

        BeCider = true;

        ADVaguely.Figurine.AlphabetArchLiterate((adType) =>
        {
            if (adType == ADType.Rewarded)
            {
                RotPestAdult();
                RotHimPestAdult("AD");
            }
        });
    }

    public void WoolSOHOLoamGreedy(Func<double> _getCashAction, Func<double> _getGoldAction, Func<double> _getAmazonAction,
        Action<double> _subCashAction, Action<double> _subGoldAction, Action<double> _subAmazonAction)
    {
        getHomeGreedy = _getCashAction;
        JobVineGreedy = _getGoldAction;
        JobSteppeGreedy = _getAmazonAction;
        RodHomeGreedy = _subCashAction;
        RodVineGreedy = _subGoldAction;
        RodSteppeGreedy = _subAmazonAction;
    }

    /// <summary>
    /// 增加现金
    /// </summary>
    /// <param name="num"></param>
    public void TurkicHome()
    {
        HomeThoughVaguely.instance.RotHomePrimacy();
    }

    /// <summary>
    /// 完成现金自定义提现条件
    /// </summary>
    /// <param name="name"></param>
    /// <param name="addValue"></param>
    public void RotWarblerWitMetalwork(string name, double addValue)
    {
        HomeThoughVaguely.instance.RotWitMetalwork(name, addValue);
    }

    /// <summary>
    /// 完成现金提现任务
    /// </summary>
    /// <param name="type"></param>
    public void RotPestAdult(string type = "AD", double addValue = 1)
    {
        HomeThoughVaguely.instance.RotPestAdult(type, addValue);
    }

    /// <summary>
    /// 完成任务（特殊增加）
    /// </summary>
    /// <param name="type"></param>
    /// <param name="addValue"></param>
    public void RotHimPestAdult(string type, double addValue = 1)
    {
        HimThoughVaguely.instance.RotPestAdult(type, addValue);
    }

    /// <summary>
    /// 打开提现商店panel
    /// </summary>
    public void FairThoughCoach()
    {
        UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(ThoughCoach)));

        // 打点
        PageBisonEmbryo.LawFigurine().SeatBison("1301", LittleJean.SummerMyNut(getHomeGreedy()));
    }

    /// <summary>
    /// 金币/Amazon提现Panel
    /// </summary>
    public void FairVineSteppeThoughCoach()
    {
        UIInject.LawFigurine().FairUIMarry(SOHOLoamCopyVaguely.instance.DrabJson.cash_withdraw_type == 0 ?
            SOHOLoamJean.CoachNeon(nameof(VineSteppeThoughCoach)) : SOHOLoamJean.CoachNeon(nameof(HimThoughCoach)));
        // 打点
        PageBisonEmbryo.LawFigurine().SeatBison("1302", LittleJean.SummerMyNut(JobVineGreedy()), LittleJean.SummerMyNut(JobSteppeGreedy()));
    }

    /// <summary>
    /// 碎片兑换panel
    /// </summary>
    public void FairThoughTollCoach()
    {
        UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(ThoughTollCoach)));
        // 打点
        PageBisonEmbryo.LawFigurine().SeatBison("1303");
    }

    /// <summary>
    /// 随机获得一个碎片奖励
    /// </summary>
    /// <returns></returns>
    public Seeker LawMeadowSeeker()
    {
        return SOHOSeekerVaguely.instance.JobMissionarySeeker();
    }

    /// <summary>
    /// 获取碎片
    /// </summary>
    public void RotMeadowSeeker(Seeker puzzle)
    {
        // 领取碎片动画
        SOHOSeekerVaguely.instance.LotSeeker(puzzle);
    }

    /// <summary>
    /// 现金提现倒计时
    /// </summary>
    /// <returns></returns>
    public long LawHomeTolerantWhaleWide()
    {
        return BeCider ? HomeThoughVaguely.instance.JobPredateWhaleWide() : 0;
    }

    /// <summary>
    /// 是否有未提现的现金提现记录
    /// </summary>
    /// <returns></returns>
    public bool HayManifestHomeTolerant()
    {
        return HomeThoughVaguely.instance.VasNostalgiaSink();
    }

    /// <summary>
    /// 倒计时结束时，修改提现状态
    /// </summary>
    public void HomeTolerantShrineAuthority()
    {
        HomeThoughVaguely.instance.ShrineWoolWhaleWide(null);
    }

    //获取默认提现平台图片
    public Sprite LawYucatanPryDuring()
    {
        string language = I2.Loc.LocalizationManager.CurrentLanguage;
        SlitJanuary.WithdrawMethod Method = SlitJanuary.WithdrawMethod.L;
        if (language == "Russian")
            Method = SlitJanuary.WithdrawMethod.Q;
        else if (language == "Portuguese (Brazil)")
            Method = SlitJanuary.WithdrawMethod.P;
        else if (language == "Japanese")
            Method = SlitJanuary.WithdrawMethod.M;
        else if (language == "Arabic")
            Method = SlitJanuary.WithdrawMethod.S;
        else if (language == "Indonesian")
            Method = SlitJanuary.WithdrawMethod.F;
        else if (language == "English")
        {
            Method = SlitJanuary.WithdrawMethod.A;
            string Conutry = SpyLimeYet.instance.Loosely;
            if (Conutry == "IN")
                Method = SlitJanuary.WithdrawMethod.O;
        }
        return PryConsult[(int)Method];
    }

    string[] Lint64Nut= new string[]
    {
        "UGF5UGFs",
        "QmFuY29JbnRlcg==",
        "Q2FpeGE=",
        "Q2FzaEFwcA==",
        "Q29pbmJhc2U=",
        "RGFuYU92bw==",
        "R29QYXk=",
        "TGluZVBheQ==",
        "TWVyY2Fkb1BhZ28=",
        "TnViYW5r",
        "UGFnQmFuaw==",
        "QWxpcGF5",
        "UGF5UGF5",
        "UGF5dG0=",
        "UGhvbmVQZQ==",
        "UGl4",
        "UWl3aQ==",
        "U2JlckJhbms=",
        "U3RjUGF5",
        "VGV6",
    };


    // 字符串转 Base64 编码
    public string ExcessMyLeft64(string input)
    {
        byte[] inputBytes = System.Text.Encoding.UTF8.GetBytes(input);
        return System.Convert.ToBase64String(inputBytes);
    }
    // Base64 编码转字符串
    public string Left64MyExcess(string base64Input)
    {
        byte[] base64Bytes = System.Convert.FromBase64String(base64Input);
        return System.Text.Encoding.UTF8.GetString(base64Bytes);
    }
    //获取枚举初始名称
    public string LawLintMusicianNut(SlitJanuary.WithdrawMethod method)
    {
        string str64 = Lint64Nut[(int)method];
        return Left64MyExcess(str64);
    }
}
