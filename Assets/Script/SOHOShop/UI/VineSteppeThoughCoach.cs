using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VineSteppeThoughCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("Container")]    public Transform Deprecate;
[UnityEngine.Serialization.FormerlySerializedAs("BackButton")]    public Button ChopModify;
[UnityEngine.Serialization.FormerlySerializedAs("RecordButton")]    public Button TemperModify;
[UnityEngine.Serialization.FormerlySerializedAs("InstructionsButton")]    public Button AccumulationModify;
[UnityEngine.Serialization.FormerlySerializedAs("UserAccountMathodImg")]    public Image SlitJanuaryGravelVia;
[UnityEngine.Serialization.FormerlySerializedAs("UserAccountEmailText")]    public Text SlitJanuaryCheerMine;
[UnityEngine.Serialization.FormerlySerializedAs("ReviseButton")]    public Button ClutchModify;

    // Start is called before the first frame update
    void Start()
    {
        AccumulationModify.onClick.AddListener(() =>
        {
            UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(AccumulationCoach)));
        });
        ChopModify.onClick.AddListener(() =>
        {
            ComicUIPram(SOHOLoamJean.CoachNeon(GetType().Name));
        });

        TemperModify.onClick.AddListener(() =>
        {

            StartCoroutine(WavyTemperCoach());
        });

        // 修改账户按钮
        ClutchModify.onClick.AddListener(() =>
        {
            SOHOCoachVaguely.instance.WoolEntailCoach(SOHOCoachVaguely.SourcePanel.GoldAndAmazonPanel, SOHOCoachVaguely.SourceButton.Revise, null, null, null);
            UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(TolerantCoach)));
        });

        RewriteNeuronNiche.LawFigurine().Alphabet(SOHOLoamGuard.It_BroadenVineSteppeTolerantHart, (md) =>
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

        MammothHart();
        MammothSlitJanuary();

        // 打点
        PageBisonEmbryo.LawFigurine().SeatBison("1302", LittleJean.SummerMyNut(SOHOLoamVaguely.instance.JobVineGreedy()), LittleJean.SummerMyNut(SOHOLoamVaguely.instance.JobSteppeGreedy()));

        // just for Tile Fish
        RewriteNeuronNiche.LawFigurine().Seat(CLazily.It_SorrowTill);
    }

    private void MammothHart()
    {
        VineThoughVaguely.instance.StockyCrucialMule();

        int childCount = Deprecate.childCount;
        if (childCount > 0)
        {
            for (int i = 0; i < childCount; i++)
            {
                DestroyImmediate(Deprecate.GetChild(0).gameObject);
            }
        }

        GameObject ThoughSink= SOHOLoamVaguely.instance.VineSteppeThoughSink;
        double gold = SOHOLoamVaguely.instance.JobVineGreedy();
        double amazon = SOHOLoamVaguely.instance.JobSteppeGreedy();
        double Dual= SOHOLoamVaguely.instance.getHomeGreedy();
        for (int i = 0; i < VineThoughVaguely.instance.EpicThoughSpout.Length; i++)
        {
            VineThough item = VineThoughVaguely.instance.EpicThoughSpout[i];
            if (item.state != Though.RedeemState.Complete)
            {
                GameObject obj = Instantiate(ThoughSink, Deprecate);
                obj.GetComponent<VineSteppeThoughSink>().WoolSink(item, gold, amazon, Dual, i);
            }
        }
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
            SlitJanuaryGravelVia.sprite = SOHOLoamVaguely.instance.PryConsult[(int)BluefinSlitJanuary.Suburb];
            SlitJanuaryCheerMine.text = BluefinSlitJanuary.Sloth;
        }
    }

    private IEnumerator WavyTemperCoach()
    {
        UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(TemperCoach)));
        yield return new WaitForSeconds(0.1f);
        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_SOHOTemperHart, new RewriteCopy("gold"));
    }

    public override void Hidding()
    {
        base.Hidding();
        // just for Tile Fish
        RewriteNeuronNiche.LawFigurine().Seat(CLazily.It_SorrowComic);
    }
}
