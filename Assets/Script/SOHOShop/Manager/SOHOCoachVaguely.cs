using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SOHOCoachVaguely : MonoBehaviour
{
    public static SOHOCoachVaguely instance;

    public enum SourcePanel { ThoughCoach, GoldAndAmazonPanel, HimThoughCoach}

    public enum SourceButton { Cashout, Revise}
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("sourcePanelName")]    public SourcePanel RecentCoachNeon;
    [HideInInspector]
[UnityEngine.Serialization.FormerlySerializedAs("sourcePanelButton")]    public SourceButton RecentCoachModify;
[UnityEngine.Serialization.FormerlySerializedAs("cashoutCashRedeem")]    public HomeThough SeminarHomeThough;
[UnityEngine.Serialization.FormerlySerializedAs("cashoutGoldRedeem")]    public VineThough SeminarVineThough;
[UnityEngine.Serialization.FormerlySerializedAs("CashoutAllRedeem")]    public HimThough WarblerHimThough;

    private void Awake()
    {
        instance = this;
    }

    public void WoolEntailCoach(SourcePanel _name, SourceButton _button, HomeThough cashRedeem, VineThough goldRedeem, HimThough allRedeem)
    {
        RecentCoachNeon = _name;
        RecentCoachModify = _button;
        SeminarHomeThough = cashRedeem;
        SeminarVineThough = goldRedeem;
        WarblerHimThough = allRedeem;
    } 
}
