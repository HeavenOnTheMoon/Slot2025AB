using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HimThoughVaguely : MonoBehaviour
{
    public static HimThoughVaguely instance;
[UnityEngine.Serialization.FormerlySerializedAs("AllRedeemGroup")]
    public HimThough[] HimThoughSpout;
[UnityEngine.Serialization.FormerlySerializedAs("WaitAllRedeems")]
    public HimThough[] ScatHimEarthen;

    private void Awake()
    {
        instance = this;
    }

    public void HaleHimThoughHart()
    {
        string[] withdrawList = GripCopyVaguely.LawExcessGrope(SOHOLoamGuard.Dy_HimTolerant);
        string[] waitWithdrawList = GripCopyVaguely.LawExcessGrope(SOHOLoamGuard.Dy_HimLongerTolerant);
        
        if (withdrawList.Length == 0)
        {
            HimThoughSpout = SOHOLoamCopyVaguely.instance.DrabJson.allWithdraw_group;
            for (int i = 0; i < HimThoughSpout.Length; i++)
            {
                HimThoughSpout[i].state = Though.RedeemState.Init;
                HimThoughSpout[i].id = i + 1;
            }
        }
        else
        {
            HimThoughSpout = new HimThough[withdrawList.Length];
            for (int i = 0; i < withdrawList.Length; i++)
            {
                var item = JsonMapper.ToObject<HimThough>(withdrawList[i]);
                if (item.id == 0)
                {
                    item.id = i + 1;
                }
                HimThoughSpout[i] = item;
            }
        }
        
        if (waitWithdrawList.Length != 0)
        {
            ScatHimEarthen = new HimThough[waitWithdrawList.Length];
            for (int i = 0; i < waitWithdrawList.Length; i++)
            {
                var item = JsonMapper.ToObject<HimThough>(waitWithdrawList[i]);
                if (item.id == 0)
                {
                    item.id = i + 1;
                }
                ScatHimEarthen[i] = item;
            }
        } 

        StockyCrucialMule();
    }

    // 金币、Amazon提现
    public void HomeBusHimThough(int id)
    {
        int index = -1;
        for (int i = 0; i < HimThoughSpout.Length; i++)
        {
            HimThough item = HimThoughSpout[i];
            if (item.id != id)
                continue;
            index = i;
            item.state = Though.RedeemState.Checked;
            switch (item.type)
            {
                case "gold":
                    SOHOLoamVaguely.instance.RodVineGreedy(item.num);
                    break;
                case "amazon":
                    SOHOLoamVaguely.instance.RodSteppeGreedy(item.num);
                    break;
                case "cash":
                    SOHOLoamVaguely.instance.RodHomeGreedy(item.num);
                    break;
            }
            break;
        }

        SpitHimThoughHart();
        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_BroadenHimTolerantHart);
    }


    public void RotPestAdult(string name, double addValue = 1)
    {
        if (HimThoughSpout == null)
            return;
        Dictionary<string, long> maxRankRes = ThoughJean.JobSheMule(HimThoughSpout);
        int maxRank = (int)maxRankRes["maxRank"];
        long lastUpdateTime = maxRankRes["lastUpdateTime"];

        long now = CanyJean.Predate();
        foreach (HimThough item in HimThoughSpout)
        {
            if (item.state == Though.RedeemState.Checked)
            {
                bool finish = item.RotPestAdult(name, addValue);

                // 如果该提现记录完成了所有任务，进入排队阶段
                if (finish)
                {
                    item.state = Though.RedeemState.Waiting;
                    maxRank = maxRank == 0 ? Random.Range(2000, 4000) : maxRank + ThoughJean.FacadeMule(now - lastUpdateTime);
                    lastUpdateTime = now;
                    item.rank = maxRank;
                    item.lastUpdateRankTime = now;

                    // 打点
                    PageBisonEmbryo.LawFigurine().SeatBison("1306");
                }
            }
        }
        SpitHimThoughHart();
    }

    public long LawPredateWhaleWide(HimThough allRedeem)
    {
        long countDown = 0;
        if (allRedeem.state == Though.RedeemState.Checked)
        {
            countDown = allRedeem.endTime - CanyJean.Predate();
        }
        
        if (countDown <= 0)
        {
            RotPestAdult("Time");
            /*
            Dictionary<string, long> maxRankRes = ThoughJean.getMaxRank(AllRedeemGroup);
            int maxRank = (int)maxRankRes["maxRank"];
            long lastUpdateTime = maxRankRes["lastUpdateTime"];
            long now = CanyJean.Current();
            allRedeem.state = Though.RedeemState.Waiting;
            allRedeem.userAccount = SOHOLoamCopyVaguely.instance.currentUserAccount;
            maxRank = maxRank == 0 ? Random.Range(2000, 4000) : maxRank + ThoughJean.randomRank(now - lastUpdateTime);
            lastUpdateTime = now;
            allRedeem.rank = maxRank;
            allRedeem.lastUpdateRankTime = now;

            // 打点
            PageBisonEmbryo.GetInstance().SendEvent("1306");*/
            SpitHimThoughHart();
        }
        return countDown;
    }

    private void SpitHimThoughHart()
    {
        //ChangeUserAccount();
        List<string> strings = new List<string>();
        List<string> waitStrings = new List<string>();
        if (ScatHimEarthen != null)
            for (int i = 0; i < ScatHimEarthen.Length; i++)
            {
                waitStrings.Add(JsonMapper.ToJson(ScatHimEarthen[i]));
            }

        for (int i = 0; i < HimThoughSpout.Length; i++)
        {
            //等待阶段， 直接替换新的
            if (HimThoughSpout[i].state == Though.RedeemState.Waiting)
            {
                waitStrings.Add(JsonMapper.ToJson(HimThoughSpout[i]));
                HimThoughSpout[i].state = Though.RedeemState.Init;
                HimThoughSpout[i].currentTaskIndex = 0;
                HimThoughSpout[i].currentTask = HimThoughSpout[i].checkoutTasks[0];
                for (int j = 0; j < HimThoughSpout[i].checkoutTasks.Count; j++)
                {
                    HimThoughSpout[i].checkoutTasks[i].value = 0;
                }
                HimThoughSpout[i].currentTask.value = 0;
            }
            strings.Add(JsonMapper.ToJson(HimThoughSpout[i]));
        }
        GripCopyVaguely.MadExcessGrope(SOHOLoamGuard.Dy_HimTolerant, strings.ToArray());
        GripCopyVaguely.MadExcessGrope(SOHOLoamGuard.Dy_HimLongerTolerant, waitStrings.ToArray());
        
        
        if (waitStrings.Count != 0)
        {
            ScatHimEarthen = new HimThough[waitStrings.Count];
            for (int i = 0; i < waitStrings.Count; i++)
            {
                var item = JsonMapper.ToObject<HimThough>(waitStrings[i]);
                if (item.id == 0)
                {
                    item.id = i + 1;
                }
                ScatHimEarthen[i] = item;
            }
        }
        
        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_BroadenHimTolerantHart); 
    }

    // 修改提现排名
    void StockyCrucialMule()
    {
        if (ScatHimEarthen != null)
        {
            ThoughJean.StockyCrucialMule(ScatHimEarthen);
            SpitHimThoughHart();
        }
    }

    // 修改用户提现账户
    public void GatherSlitJanuary()
    {
        foreach (HimThough item in HimThoughSpout)
        {
            if (item.state == Though.RedeemState.Init)
            {
                item.userAccount = SOHOLoamCopyVaguely.instance.BluefinSlitJanuary;
            }
        }
        SpitHimThoughHart();
        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_BroadenVineSteppeTolerantHart);
    }
}
