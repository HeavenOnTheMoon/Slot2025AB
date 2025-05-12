using LitJson;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VineThoughVaguely : MonoBehaviour
{
    public static VineThoughVaguely instance;
[UnityEngine.Serialization.FormerlySerializedAs("goldRedeemGroup")]
    public VineThough[] EpicThoughSpout;

    private void Awake()
    {
        instance = this;
    }

    public void HaleVineSteppeThoughHart()
    {
        string[] withdrawList = GripCopyVaguely.LawExcessGrope(SOHOLoamGuard.Dy_VineSteppeTolerant);
        if (withdrawList.Length == 0)
        {
            EpicThoughSpout = SOHOLoamCopyVaguely.instance.DrabJson.withdraw_group;
            for (int i = 0; i < EpicThoughSpout.Length; i++)
            {
                EpicThoughSpout[i].state = Though.RedeemState.Init;
                EpicThoughSpout[i].id = i + 1;
            }
        }
        else
        {
            EpicThoughSpout = new VineThough[withdrawList.Length];
            for (int i = 0; i < withdrawList.Length; i++)
            {
                VineThough item = JsonMapper.ToObject<VineThough>(withdrawList[i]);
                if (item.id == 0)
                {
                    item.id = i + 1;
                }
                EpicThoughSpout[i] = item;

            }
        }

        StockyCrucialMule();
    }

    // 金币、Amazon提现
    public void HomeBusVineThough(int id)
    {
        int index = -1;
        for (int i = 0; i < EpicThoughSpout.Length; i++)
        {
            VineThough item = EpicThoughSpout[i];
            if (item.id == id)
            {
                index = i;
                item.state = Though.RedeemState.Waiting;
                if (item.type == "gold")
                {
                    SOHOLoamVaguely.instance.RodVineGreedy(item.num);
                }
                else if(item.type == "amazon")
                {
                    SOHOLoamVaguely.instance.RodSteppeGreedy(item.num);
                } else if (item.type == "cash")
                {
                    SOHOLoamVaguely.instance.RodHomeGreedy(item.num);
                }
                break;
            }
        }

        Dictionary<string, long> maxRankRes = ThoughJean.JobSheMule(EpicThoughSpout);
        int maxRank = (int)maxRankRes["maxRank"];
        long lastUpdateTime = maxRankRes["lastUpdateTime"];
        long now = CanyJean.Predate();
        maxRank = maxRank == 0 ? Random.Range(2000, 4000) : maxRank + ThoughJean.FacadeMule(now - lastUpdateTime);
        EpicThoughSpout[index].rank = maxRank;
        EpicThoughSpout[index].lastUpdateRankTime = now;

        SpitVineThoughHart();
        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_BroadenVineSteppeTolerantHart);
    }
    

    private void SpitVineThoughHart()
    {
        List<string> strings = new List<string>();
        foreach (VineThough item in EpicThoughSpout)
        {
            strings.Add(JsonMapper.ToJson(item));
        }
        GripCopyVaguely.MadExcessGrope(SOHOLoamGuard.Dy_VineSteppeTolerant, strings.ToArray());
    }

    // 修改提现排名
    public void StockyCrucialMule()
    {
        ThoughJean.StockyCrucialMule(EpicThoughSpout);
        SpitVineThoughHart();
    }

    // 修改用户提现账户
    public void GatherSlitJanuary()
    {
        foreach (VineThough item in EpicThoughSpout)
        {
            if (item.state == Though.RedeemState.Init)
            {
                item.userAccount = SOHOLoamCopyVaguely.instance.BluefinSlitJanuary;
            }
        }
        SpitVineThoughHart();
        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_BroadenVineSteppeTolerantHart);
    }
}
