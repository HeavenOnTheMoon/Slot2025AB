using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ThoughCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("HomeButton")]    public Button LiveModify;
[UnityEngine.Serialization.FormerlySerializedAs("ReviseButton")]    public Button ClutchModify;
[UnityEngine.Serialization.FormerlySerializedAs("RecordButton")]    public Button TemperModify;
[UnityEngine.Serialization.FormerlySerializedAs("InstructionsButton")]    public Button AccumulationModify;
[UnityEngine.Serialization.FormerlySerializedAs("Container")]    public Transform Deprecate;
[UnityEngine.Serialization.FormerlySerializedAs("UserAccountMathodImg")]    public Image SlitJanuaryGravelVia;
[UnityEngine.Serialization.FormerlySerializedAs("UserAccountEmailText")]    public Text SlitJanuaryCheerMine;
[UnityEngine.Serialization.FormerlySerializedAs("layout")]    public HorizontalLayoutGroup Bypass;

    private void Start()
    {
        LiveModify.onClick.AddListener(() =>
        {
            ComicUIPram(SOHOLoamJean.CoachNeon(GetType().Name));
        });

        // 修改账户按钮
        ClutchModify.onClick.AddListener(() =>
        {
            SOHOCoachVaguely.instance.WoolEntailCoach(SOHOCoachVaguely.SourcePanel.ThoughCoach, SOHOCoachVaguely.SourceButton.Revise, null, null, null);
            UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(TolerantCoach)));
        });

        // 提现历史按钮
        TemperModify.onClick.AddListener(() =>
        {
            StartCoroutine(WavyTemperCoach());
        });

        AccumulationModify.onClick.AddListener(() =>
        {
            UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(AccumulationCoach)));
        });

        RewriteNeuronNiche.LawFigurine().Alphabet(SOHOLoamGuard.It_BroadenHomeTolerantHart, (md) =>
        {
            MammothHart();
        });

        RewriteNeuronNiche.LawFigurine().Alphabet(SOHOLoamGuard.It_BroadenHomeTolerantSlitJanuary, (md) =>
        {
            MammothSlitJanuary();
        });

    }

    public override void Display()
    {
        base.Display();

        HomeThoughVaguely.instance.WoolHomeTolerant();

        MammothHart();
        MammothSlitJanuary();

        // 打点
        PageBisonEmbryo.LawFigurine().SeatBison("1301", LittleJean.SummerMyNut(SOHOLoamVaguely.instance.getHomeGreedy()));

    }

    private void MammothSlitJanuary()
    {
        SlitJanuary BluefinSlitJanuary= SOHOLoamCopyVaguely.instance.BluefinSlitJanuary;
        
        if (BluefinSlitJanuary == null)
        {
            SlitJanuaryGravelVia.sprite = SOHOLoamVaguely.instance.LawYucatanPryDuring();
            SlitJanuaryCheerMine.text = "Please enter your withdrawal account";
        }
        else
        {
            Debug.Log("===============================        " + BluefinSlitJanuary.Suburb);
            SlitJanuaryGravelVia.sprite = SOHOLoamVaguely.instance.PryConsult[(int) BluefinSlitJanuary.Suburb];
            SlitJanuaryCheerMine.text = BluefinSlitJanuary.Sloth;
        }
    }

    private void MammothHart()
    {
        if (!gameObject.activeSelf)
        {
            return;
        }
        int childCount = Deprecate.childCount;
        if (childCount > 0)
        {
            for (int i = 0; i < childCount; i++)
            {
                DestroyImmediate(Deprecate.GetChild(0).gameObject);
            }
        }

        for (int i = HomeThoughVaguely.instance.HomeThoughHart.Count; i > 0; i--)
        {
            HomeThough item = HomeThoughVaguely.instance.HomeThoughHart[i - 1];
            if (item.state != Though.RedeemState.Complete )
            {
                if (item.state == Though.RedeemState.Checked)
                {
                    Debug.Log("===================  item.state    " + item.state + "   ===========        " + item.cashout);
                    if (item.cashout > 0)
                    {
                        GameObject redeemItem = Instantiate(SOHOLoamVaguely.instance.ThoughSink, Deprecate);
                        redeemItem.GetComponent<ThoughSink>().WoolThoughSink(item);
                    }
                }
                else
                {
                    GameObject redeemItem = Instantiate(SOHOLoamVaguely.instance.ThoughSink, Deprecate);
                    redeemItem.GetComponent<ThoughSink>().WoolThoughSink(item);
                }
            }
        }

        if (!RetoolJean.MyFidelity())
        {
            if (HomeThoughVaguely.instance.HomeThoughHart.Count == 1)
            {
                Bypass.childAlignment = TextAnchor.MiddleCenter;
                Bypass.GetComponent<RectTransform>().MadLayout(AnchorPresets.MiddleCenter);
                Bypass.GetComponent<RectTransform>().MadFlour(PivotPresets.MiddleCenter);
                Bypass.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            }
            else
            {
                Bypass.childAlignment = TextAnchor.MiddleLeft;
                Bypass.GetComponent<RectTransform>().MadLayout(AnchorPresets.MiddleLeft);
                Bypass.GetComponent<RectTransform>().MadFlour(PivotPresets.MiddleLeft);
                Bypass.GetComponent<RectTransform>().anchoredPosition = new Vector2(0, 0);
            }
        }

        Deprecate.GetComponent<RectTransform>().sizeDelta = new Vector2(Deprecate.GetComponent<RectTransform>().sizeDelta.x, 430 * HomeThoughVaguely.instance.HomeThoughHart.Count);

    }


    private IEnumerator WavyTemperCoach()
    {
        UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(TemperCoach)));
        yield return new WaitForSeconds(0.1f);
        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_SOHOTemperHart, new RewriteCopy("cash"));
    }

    public override void Hidding()
    {
        base.Hidding();
    }
}
