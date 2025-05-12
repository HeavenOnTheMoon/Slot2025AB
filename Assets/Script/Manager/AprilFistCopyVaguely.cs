using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AprilFistCopyVaguely : EarnCommunity<AprilFistCopyVaguely>
{
    // Start is called before the first frame update
    void Start()
    {

    }

    public void WoolFistCopy()
    {
        // 提现商店初始化
        // 提现商店中的金币、现金和amazon卡均为double类型，参数请根据具体项目自行处理
        SOHOLoamVaguely.instance.WoolSOHOLoamGreedy(
            JobBloom,
            JobVine,
            JobSteppe,    // amazon
            (subToken) => { LotBloom(-subToken); },
            (subGold) => { LotVine(-subGold); },
            (subAmazon) => { LotSteppe(-subAmazon); });

    }

    // 金币
    public double JobVine()
    {

        return GripCopyVaguely.LawSummer(CLazily.Dy_VineHave);
    }

    public void LotVine(double gold)
    {
        LotVine(gold, AprilWarmVaguely.instance.transform);
    }

    public void LotVine(double gold, Transform startTransform)
    {
        double oldGold = GripCopyVaguely.LawSummer(CLazily.Dy_VineHave);
        GripCopyVaguely.MadSummer(CLazily.Dy_VineHave, oldGold + gold);
        if (gold > 0)
        {
            GripCopyVaguely.MadSummer(CLazily.Dy_SerigraphyVineHave, GripCopyVaguely.LawSummer(CLazily.Dy_SerigraphyVineHave) + gold);
        }
        RewriteCopy md = new RewriteCopy(oldGold);
        md.FiordObedience = startTransform;
        RewriteNeuronNiche.LawFigurine().Seat(CLazily.It_He_Jawbone, md);
    }

    // 现金
    public double JobBloom()
    {
        return GripCopyVaguely.LawSummer(CLazily.Dy_Bloom);
    }

    public void LotBloom(double token)
    {
        LotBloom(token, AprilWarmVaguely.instance.transform);
    }
    public void LotBloom(double token, Transform startTransform)
    {
        double oldToken = PlayerPrefs.HasKey(CLazily.Dy_Bloom) ? double.Parse(GripCopyVaguely.LawExcess(CLazily.Dy_Bloom)) : 0;
        double newToken = oldToken + token;
        GripCopyVaguely.MadSummer(CLazily.Dy_Bloom, newToken);
        if (token > 0)
        {
            double allToken = GripCopyVaguely.LawSummer(CLazily.Dy_SerigraphyBloom);
            GripCopyVaguely.MadSummer(CLazily.Dy_SerigraphyBloom, allToken + token);
            /*#if SOHOShop
                        SOHOLoamVaguely.instance.AddCash(token);
            #endif*/
        }
        SOHOLoamVaguely.instance.TurkicHome();

        RewriteCopy md = new RewriteCopy(oldToken);
        md.FiordObedience = startTransform;
        RewriteNeuronNiche.LawFigurine().Seat(CLazily.It_He_Atlantic, md);
    }

    //Amazon卡
    public double JobSteppe()
    {
        return GripCopyVaguely.LawSummer(CLazily.Dy_Steppe);
    }

    public void LotSteppe(double amazon)
    {
        LotSteppe(amazon, AprilWarmVaguely.instance.transform);
    }
    public void LotSteppe(double amazon, Transform startTransform)
    {
        double oldAmazon = PlayerPrefs.HasKey(CLazily.Dy_Steppe) ? double.Parse(GripCopyVaguely.LawExcess(CLazily.Dy_Steppe)) : 0;
        double newAmazon = oldAmazon + amazon;
        GripCopyVaguely.MadSummer(CLazily.Dy_Steppe, newAmazon);
        if (amazon > 0)
        {
            double allAmazon = GripCopyVaguely.LawSummer(CLazily.Dy_SerigraphySteppe);
            GripCopyVaguely.MadSummer(CLazily.Dy_SerigraphySteppe, allAmazon + amazon);
        }
        RewriteCopy md = new RewriteCopy(oldAmazon);
        md.FiordObedience = startTransform;
        RewriteNeuronNiche.LawFigurine().Seat(CLazily.It_He_Shoemaker, md);
    }
}
