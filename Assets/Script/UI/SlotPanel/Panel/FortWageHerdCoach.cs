using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortWageHerdCoach : LeftUIMarry
{
    public static FortWageHerdCoach Instance;
[UnityEngine.Serialization.FormerlySerializedAs("Text_FreeNumber")]    public Text Mine_WageLittle;
[UnityEngine.Serialization.FormerlySerializedAs("Button_AddNumber")]    public Button Modify_RotLittle;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Close")]    public Button Modify_Comic;
[UnityEngine.Serialization.FormerlySerializedAs("FreeAction")]
    public Action WageGreedy;
    protected override void Awake()
    {
        base.Awake();
        Instance = this;
    }

    public override void Display()
    {
        base.Display();
        GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_Freespin_Start);
        //StartCoroutine(nameof(DelayOpenFreeSpin));
        Mine_WageLittle.text = FortCopyVaguely.instance.WageHerdLittle.ToString();
        StartCoroutine(nameof(HabitFairWeADModify));
    }

    private void Start()
    {
        Modify_RotLittle.onClick.AddListener(()=> {
            ADVaguely.Figurine.HookMeadowAlike((success) =>
            {
                if (success)
                {
                    FortCopyVaguely.instance.WageHerdLittle = FortCopyVaguely.instance.WageHerdLittle + 4;
                    FortCopyVaguely.instance.WageHerdHimLittle = FortCopyVaguely.instance.WageHerdLittle;
                    PageBisonEmbryo.LawFigurine().SeatBison("1008", "1", FortCopyVaguely.instance.WageHerdLittle.ToString() );
                    WageGreedy?.Invoke();
                    GlobeYet.LawFigurine().ArchDy(GlobeThus.SceneMusic.Sound_Quick7_Freespin_BGM);
                    SeatWageHerdDecay();
                    ComicUIPram(nameof(FortWageHerdCoach));
                }
            }, "11");
        });

        Modify_Comic.onClick.AddListener(() => {
            WageGreedy?.Invoke();
            GlobeYet.LawFigurine().ArchDy(GlobeThus.SceneMusic.Sound_Quick7_Freespin_BGM);
            SeatWageHerdDecay();
            PageBisonEmbryo.LawFigurine().SeatBison("1008", "1", FortCopyVaguely.instance.WageHerdLittle.ToString());
            ComicUIPram(nameof(FortWageHerdCoach));
        });
    }

    public void MadWageGreedy(Action action)
    {
        WageGreedy = action;
    }

    public void SeatWageHerdDecay()
    {
        RewriteNeuronNiche.LawFigurine().Seat("SendFreeSpinStart", null);
    }

    IEnumerator HabitTillWageHerd()
    {
        yield return new WaitForSeconds(2f);
        ComicUIPram(nameof(FortWageHerdCoach));
    }

    IEnumerator HabitFairWeADModify()
    {
        Modify_Comic.gameObject.SetActive(false);
        yield return new WaitForSeconds(2f);
        Modify_Comic.gameObject.SetActive(true);
    }
}
