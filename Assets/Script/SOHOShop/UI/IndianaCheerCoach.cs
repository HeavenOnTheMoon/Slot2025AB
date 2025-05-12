using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IndianaCheerCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("RewardText")]    public Text MeadowMine;
[UnityEngine.Serialization.FormerlySerializedAs("AccountText")]    public Text JanuaryMine;
[UnityEngine.Serialization.FormerlySerializedAs("EmailText")]    public Text CheerMine;
[UnityEngine.Serialization.FormerlySerializedAs("ConfirmBtn")]    public Button IndianaIts;
[UnityEngine.Serialization.FormerlySerializedAs("ReviseBtn")]    public Button ClutchIts;

    private void Start()
    {
        IndianaIts.onClick.AddListener(() =>
        {
            if (SOHOCoachVaguely.instance.RecentCoachNeon == SOHOCoachVaguely.SourcePanel.ThoughCoach)
            {
                HomeThoughVaguely.instance.TrailHomeTolerant(SOHOCoachVaguely.instance.SeminarHomeThough.id);
            }
            else if (SOHOCoachVaguely.instance.RecentCoachNeon == SOHOCoachVaguely.SourcePanel.GoldAndAmazonPanel)
            {
                VineThoughVaguely.instance.HomeBusVineThough(SOHOCoachVaguely.instance.SeminarVineThough.id);
            }
            else
            {
                HimThoughVaguely.instance.HomeBusHimThough(SOHOCoachVaguely.instance.WarblerHimThough.id);
            }
            FortCopyVaguely.instance.SeatLeoHerdMeadow();
            ComicUIPram(SOHOLoamJean.CoachNeon(GetType().Name));
        });

        ClutchIts.onClick.AddListener(() =>
        {
            SOHOCoachVaguely.instance.RecentCoachModify = SOHOCoachVaguely.SourceButton.Revise;
            UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(TolerantCoach)));
        });

        // 更新用户账户
        RewriteNeuronNiche.LawFigurine().Alphabet(SOHOLoamGuard.It_BroadenHomeTolerantSlitJanuary, (md) =>
        {
            JanuaryMine.text = "Please confirm " + SOHOLoamCopyVaguely.instance.BluefinSlitJanuary.Suburb.ToString() + " accout:";
            CheerMine.text = SOHOLoamCopyVaguely.instance.BluefinSlitJanuary.Sloth;
        });
    }

    public override void Display()
    {
        base.Display();

        if (SOHOLoamCopyVaguely.instance.BluefinSlitJanuary == null)
        {
            UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(TolerantCoach)));
            ComicUIPram(SOHOLoamJean.CoachNeon(GetType().Name));
        }
        else
        {
            JanuaryMine.text = "Please confirm " + SOHOLoamCopyVaguely.instance.BluefinSlitJanuary.Suburb.ToString() + " accout:";
            CheerMine.text = SOHOLoamCopyVaguely.instance.BluefinSlitJanuary.Sloth;
        }

        if (SOHOCoachVaguely.instance.RecentCoachNeon == SOHOCoachVaguely.SourcePanel.ThoughCoach)
        {
            MeadowMine.text = "$" + LittleJean.SummerMyNut(SOHOCoachVaguely.instance.SeminarHomeThough.cashout);
        }
        else if (SOHOCoachVaguely.instance.RecentCoachNeon == SOHOCoachVaguely.SourcePanel.GoldAndAmazonPanel)
        {
            MeadowMine.text = "$" + LittleJean.SummerMyNut(SOHOCoachVaguely.instance.SeminarVineThough.cashout);
        }
        else
        {
            MeadowMine.text = "$" + LittleJean.SummerMyNut(SOHOCoachVaguely.instance.WarblerHimThough.cashout);
        }

    }
}
