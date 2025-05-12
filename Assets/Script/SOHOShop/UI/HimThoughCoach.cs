using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HimThoughCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("Container")]    public Transform Deprecate;
[UnityEngine.Serialization.FormerlySerializedAs("BackButton")]    public Button ChopModify;
[UnityEngine.Serialization.FormerlySerializedAs("RecordButton")]    public Button TemperModify;
[UnityEngine.Serialization.FormerlySerializedAs("InstructionsButton")]    public Button AccumulationModify;
[UnityEngine.Serialization.FormerlySerializedAs("UserAccountMathodImg")]    public Image SlitJanuaryGravelVia;
[UnityEngine.Serialization.FormerlySerializedAs("UserAccountEmailText")]    public Text SlitJanuaryCheerMine;
[UnityEngine.Serialization.FormerlySerializedAs("ReviseButton")]    public Button ClutchModify;

    private List<GameObject> HaleHart= new List<GameObject>();
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
            SOHOCoachVaguely.instance.WoolEntailCoach(SOHOCoachVaguely.SourcePanel.HimThoughCoach, SOHOCoachVaguely.SourceButton.Revise, null, null, null);
            UIInject.LawFigurine().FairUIMarry(SOHOLoamJean.CoachNeon(nameof(TolerantCoach)));
        });

        RewriteNeuronNiche.LawFigurine().Alphabet(SOHOLoamGuard.It_BroadenHimTolerantHart, (md) =>
        {
            MammothHart();
        });

        RewriteNeuronNiche.LawFigurine().Alphabet(SOHOLoamGuard.It_BroadenHomeTolerantSlitJanuary, (md) =>
        {
            MammothSlitJanuary();
        });
        //生成小组件
        ShapeSinkBis();
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
        WoolSinkBis();
    }


    private void ShapeSinkBis()
    {
        for (int i = 0; i < HimThoughVaguely.instance.HimThoughSpout.Length; i++)
        {
            GameObject obj = Instantiate(SOHOLoamVaguely.instance.HimHaleSink);
            obj.transform.SetParent(Deprecate.transform, false);
            obj.GetComponent<HaleMuseum>().HimThough = HimThoughVaguely.instance.HimThoughSpout[i];
            HaleHart.Add(obj);
            obj.GetComponent<HaleMuseum>().WoolLime();
        }
    }

    private void WoolSinkBis()
    {
        foreach (var item in HaleHart)
        {
            item.GetComponent<HaleMuseum>().WoolLime();
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
        RewriteNeuronNiche.LawFigurine().Seat(SOHOLoamGuard.It_SOHOTemperHart, new RewriteCopy("All"));
    }

    public override void Hidding()
    {
        base.Hidding();
        // just for Tile Fish
        RewriteNeuronNiche.LawFigurine().Seat(CLazily.It_SorrowComic);
    }
}
