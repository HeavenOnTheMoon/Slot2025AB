using LitJson;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HomeThoughVaguely : MonoBehaviour
{
    public static HomeThoughVaguely instance;
[UnityEngine.Serialization.FormerlySerializedAs("CashRedeemList")]
    public List<HomeThough> HomeThoughHart; // 提现记录

    private void Awake()
    {
        instance = this;
    }

    public void WoolHomeTolerant()
    {
        // 提现列表
        if (HomeThoughHart == null || HomeThoughHart.Count == 0)
        {
            HomeThoughHart = new List<HomeThough>();
            string[] stringList = GripCopyVaguely.LawExcessGrope(SOHOLoamGuard.Dy_HomeTolerantHart);
            foreach (string item in stringList)
            {
                HomeThough redeem = JsonMapper.ToObject<HomeThough>(item);
                HomeThoughHart.Add(redeem);
            }
        }

        StockyHomeTolerant();
        StockyCrucialMule();

    }

    // 检查更新绿币提现记录
    private void StockyHomeTolerant()
    {
        long current = CanyJean.Predate();
        long[] timePoints = SOHODateUtil.DecayIcyBoyBraceTheyNoBur();
        long startTime = HomeThoughHart.Count == 0 ? current : timePoints[0];
        long endTime = startTime + SOHOLoamCopyVaguely.instance.DrabJson.cash_withdraw_time;

        double cashBalance = GripCopyVaguely.LawSummer(SOHOLoamGuard.Dy_HomeTolerantPrimacy);
        // 判断当前时间点是否已有记录
        bool flag = false;
        foreach (HomeThough item in HomeThoughHart)
        {
            if (item.state == Though.RedeemState.Init)
            {
                // 如果当前时间已经有记录，则跳过；否则修改已有记录状态
                if (item.startTime <= current && item.endTime > current)
                {
                    flag = true;
                    item.cashout = cashBalance;
                }
                else
                {
                    if (cashBalance <= 0)
                    {
                        // 如果当前的记录余额为0，则重新开始倒计时
                        flag = true;
                        item.startTime = startTime;
                        item.endTime = endTime;
                    }
                    else
                    {
                        item.state = Though.RedeemState.Unchecked;
                        item.cashout = cashBalance;
                        cashBalance = 0;
                        GripCopyVaguely.MadExcess(SOHOLoamGuard.Dy_HomeTolerantPrimacy, cashBalance.ToString());

                        // 打点
                        PageBisonEmbryo.LawFigurine().SeatBison("1304", LittleJean.SummerMyNut(item.cashout));
                    }
                }
                item.ManChapbook = item.TrailCanWarbler();
            }
        }
        if (!flag)
        {
            // 创建新记录
            HomeThough newCashWighdraw = new HomeThough();
            newCashWighdraw.id = HomeThoughHart.Count;
            newCashWighdraw.cashout = cashBalance;
            newCashWighdraw.startTime = startTime;
            newCashWighdraw.endTime = endTime;
            HomeThoughHart.Add(newCashWighdraw);
        }
        // 保存提现记录
        SpitHomeAwkwardlyHart();

        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_BroadenAuthority);
        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_FairHomeLoamLung, new RewriteCopy(false));
    }

    /// <summary>
    /// 保存提现记录
    /// </summary>
    private void SpitHomeAwkwardlyHart()
    {
        List<string> strings = new List<string>();
        foreach (HomeThough item in HomeThoughHart)
        {
            strings.Add(JsonMapper.ToJson(item));
        }
        GripCopyVaguely.MadExcessGrope(SOHOLoamGuard.Dy_HomeTolerantHart, strings.ToArray());
        // 刷新列表
        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_BroadenHomeTolerantHart);
    }

    /// <summary>
    /// 增加现金余额
    /// </summary>
    /// <param name="num"></param>
    public void RotHomePrimacy()
    {
        double balance = SOHOLoamVaguely.instance.getHomeGreedy();
        foreach (HomeThough item in HomeThoughHart)
        {
            if (item.state == Though.RedeemState.Unchecked)
            {
                balance -= item.cashout;
            }
        }
        GripCopyVaguely.MadSummer(SOHOLoamGuard.Dy_HomeTolerantPrimacy, balance);
        StockyHomeTolerant();
    }

    /// <summary>
    /// 是否有未提现的记录
    /// </summary>
    /// <returns></returns>
    public bool HayNostalgiaSeedyHomeTolerant()
    {
        foreach (HomeThough item in HomeThoughHart)
        {
            if (item.state == Though.RedeemState.Unchecked)
            {
                return true;
            }
        }
        return false;
    }

    public void RotWitMetalwork(string name, double addValue)
    {
        foreach (HomeThough item in HomeThoughHart)
        {
            if (item.state == Though.RedeemState.Init && !item.ManChapbook)
            {
                item.RotWitMetalworkAdult(name, addValue);
            }
        }
    }

    /// <summary>
    /// 完成一个提现任务
    /// </summary>
    /// <param name="type"></param>
    public void RotPestAdult(string type = "AD", double addValue = 1)
    {
        Dictionary<string, long> maxRankRes = ThoughJean.JobSheMule(HomeThoughHart.ToArray());
        int maxRank = (int)maxRankRes["maxRank"];
        long lastUpdateTime = maxRankRes["lastUpdateTime"];

        long now = CanyJean.Predate();
        foreach (HomeThough item in HomeThoughHart)
        {
            if (item.state == Though.RedeemState.Checked)
            {
                item.JuryAdult++;
                bool finish = item.RotPestAdult(type, addValue);

                // 如果该提现记录完成了所有任务，进入排队阶段
                if (finish)
                {
                    item.state = Though.RedeemState.Waiting;
                    maxRank = maxRank == 0 ? UnityEngine.Random.Range(2000, 4000) : maxRank + ThoughJean.FacadeMule(now - lastUpdateTime);
                    lastUpdateTime = now;
                    item.rank = maxRank;
                    item.lastUpdateRankTime = now;

                    // 打点
                    PageBisonEmbryo.LawFigurine().SeatBison("1306");
                }
            }
        }
        SpitHomeAwkwardlyHart();
    }

    /// <summary>
    /// 提现
    /// </summary>
    /// <param name="id"></param>
    public void TrailHomeTolerant(int id)
    {
        if (SOHOLoamCopyVaguely.instance.BluefinSlitJanuary == null)
        {
            UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(TolerantCoach)));
            return;
        }

        HomeThough selectedCashWithdraw = null;
        foreach (HomeThough item in HomeThoughHart)
        {
            if (item.id == id)
            {
                selectedCashWithdraw = item;
                break;
            }
        }

        if (selectedCashWithdraw == null || !(selectedCashWithdraw.state == Though.RedeemState.Unchecked || selectedCashWithdraw.state == Though.RedeemState.Init && selectedCashWithdraw.ManChapbook))
        {
            return;
        }

        if (selectedCashWithdraw.state == Though.RedeemState.Init)
        {
            GripCopyVaguely.MadExcess(SOHOLoamGuard.Dy_HomeTolerantPrimacy, "0");
            long nowTicks = CanyJean.Predate();  // 当前时间
            long startTicks = CanyJean.LawWaterside(DateTime.Today); // 当日零点时间
            int initSeconds = (int)(nowTicks - startTicks);
            GripCopyVaguely.MadAid(SOHOLoamGuard.Dy_WoolParadox, initSeconds);
        }
        // 修改记录状态
        selectedCashWithdraw.state = Though.RedeemState.Checked;
        selectedCashWithdraw.endTime = CanyJean.Predate() > selectedCashWithdraw.endTime ? selectedCashWithdraw.endTime : CanyJean.Predate();
        selectedCashWithdraw.JuryAdult = 0;
        // 扣除游戏现金余额
        SOHOLoamVaguely.instance.RodHomeGreedy(selectedCashWithdraw.cashout);
        SpitHomeAwkwardlyHart();
        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_FairHomeLoamLung, new RewriteCopy(false));

        // 检查更新提现记录
        StockyHomeTolerant();

        // 打点
        PageBisonEmbryo.LawFigurine().SeatBison("1305");
    }

    // 到达可提现时间
    public void ShrineWoolWhaleWide(HomeThough obj)
    {
        StockyHomeTolerant();
    }

    // 每隔一段时间，减少提现排队当前排名
    public void StockyCrucialMule()
    {
        ThoughJean.StockyCrucialMule(HomeThoughHart.ToArray());
        SpitHomeAwkwardlyHart();
    }


    /// <summary>
    /// 修改用户账户
    /// </summary>
    public void GatherSlitJanuary()
    {
        foreach (HomeThough item in HomeThoughHart)
        {
            if ((item.userAccount == null || item.state == Though.RedeemState.Init || item.state == Though.RedeemState.Unchecked)
                && SOHOLoamCopyVaguely.instance.BluefinSlitJanuary != null)
            {
                item.userAccount = SOHOLoamCopyVaguely.instance.BluefinSlitJanuary;
            }
        }
        // 保存提现记录
        SpitHomeAwkwardlyHart();
        // 刷新页面
        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_BroadenHomeTolerantHart);
        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_BroadenHomeTolerantSlitJanuary);
    }

    // 计算init状态的记录倒计时
    public long JobPredateWhaleWide()
    {
        long countdown = 0;
        foreach (HomeThough item in HomeThoughHart)
        {
            if (item.state == Though.RedeemState.Init)
            {
                countdown = item.endTime - CanyJean.Predate();
                break;
            }
        }

        return countdown;
    }

    // 是否有未点击提现的记录
    public bool VasNostalgiaSink()
    {
        foreach (HomeThough item in HomeThoughHart)
        {
            if (item.state == Though.RedeemState.Unchecked || item.state == Though.RedeemState.Init && item.ManChapbook)
            {
                return true;
            }
        }
        return false;
    }
}
