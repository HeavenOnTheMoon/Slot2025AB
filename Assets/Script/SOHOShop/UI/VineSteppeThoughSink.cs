using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VineSteppeThoughSink : MonoBehaviour
{
[UnityEngine.Serialization.FormerlySerializedAs("PayImage")]    public Image PrySlice;
[UnityEngine.Serialization.FormerlySerializedAs("State_1")]    public GameObject Seedy_1;
[UnityEngine.Serialization.FormerlySerializedAs("GoldImage")]    public GameObject VineSlice;
[UnityEngine.Serialization.FormerlySerializedAs("AmazonImage")]    public GameObject SteppeSlice;
[UnityEngine.Serialization.FormerlySerializedAs("CashImage")]    public GameObject HomeSlice;
[UnityEngine.Serialization.FormerlySerializedAs("ProgressImage")]    public Image SecretinSlice;
[UnityEngine.Serialization.FormerlySerializedAs("CashoutText")]    public Text WarblerMine;
[UnityEngine.Serialization.FormerlySerializedAs("CashOutBtn")]    public Button HomeBusIts;
[UnityEngine.Serialization.FormerlySerializedAs("State_2")]
    public GameObject Seedy_2;
[UnityEngine.Serialization.FormerlySerializedAs("RankText")]    public Text MuleMine;

    private double EpicOrSteppe;
    private VineThough EpicThoughSink;

    private void Start()
    {
        HomeBusIts.onClick.AddListener(() =>
        {
            if (EpicOrSteppe >= EpicThoughSink.num)
            {
                SOHOCoachVaguely.instance.WoolEntailCoach(SOHOCoachVaguely.SourcePanel.GoldAndAmazonPanel, SOHOCoachVaguely.SourceButton.Cashout, null, EpicThoughSink, null);
                UIInject.LawFigurine().FairUIMarry(SOHOLoamCopyVaguely.instance.BluefinSlitJanuary == null ? SOHOLoamJean.CoachNeon(nameof(TolerantCoach)) : SOHOLoamJean.CoachNeon(nameof(IndianaCheerCoach)));
            }
            else
            {
                string msg = EpicThoughSink.type switch
                {
                    "gold" => "Gold is not enough",
                    "amazon" => "Amazon is not enough",
                    "cash" => "Cash is not enough",
                    _ => "Gold is not enough"
                };
                GropeVaguely.LawFigurine().FairGrope(msg);
            }

        });
    }

    public void WoolSink(VineThough item, double gold, double amazon, double cash, int index)
    {
        EpicThoughSink = item;

        SlitJanuary BluefinSlitJanuary= SOHOLoamCopyVaguely.instance.BluefinSlitJanuary;
        PrySlice.sprite = BluefinSlitJanuary == null ? SOHOLoamVaguely.instance.LawYucatanPryDuring()
            : SOHOLoamVaguely.instance.PryConsult[(int) BluefinSlitJanuary.Suburb];


        switch (EpicThoughSink.state)
        {
            case Though.RedeemState.Init:
                {
                    Seedy_1.SetActive(true);
                    Seedy_2.SetActive(false);
                    GameObject activeObj = VineSlice;
                    EpicOrSteppe = gold;
                    switch (item.type)
                    {
                        case "gold":
                            activeObj = VineSlice;
                            EpicOrSteppe = gold;
                            break;
                        case "amazon":
                            activeObj = SteppeSlice;
                            EpicOrSteppe = amazon;
                            break;
                        case "cash":
                            activeObj = HomeSlice;
                            EpicOrSteppe = cash;
                            break;
                    }
                    activeObj.SetActive(true);
                    activeObj.transform.Find("Text").GetComponent<Text>().text = LittleJean.SummerMyNut(EpicOrSteppe) + "/" + item.num;
                    SecretinSlice.fillAmount = (float)(EpicOrSteppe / item.num);
                    WarblerMine.text = "$" + item.cashout;

                    HomeBusIts.gameObject.SetActive(item.state == Though.RedeemState.Init);
                    break;
                }
            case Though.RedeemState.Waiting:
                WarblerMine.text = "$" + item.cashout;
                Seedy_1.SetActive(false);
                Seedy_2.SetActive(true);
                MuleMine.text = "Your current queue position is: " + EpicThoughSink.rank;
                break;
        }

    }

}
