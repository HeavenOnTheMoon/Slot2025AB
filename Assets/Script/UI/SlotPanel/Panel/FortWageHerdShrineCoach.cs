using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortWageHerdShrineCoach : LeftUIMarry
{
    public static FortWageHerdShrineCoach Instance;
[UnityEngine.Serialization.FormerlySerializedAs("Text_Coin")]    public Text Mine_Have;
[UnityEngine.Serialization.FormerlySerializedAs("Text_SpinNumber")]    public Text Mine_HerdLittle;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Coin")]    public Image Slice_Have;
[UnityEngine.Serialization.FormerlySerializedAs("Button_OK")]    public Button Modify_OK;
[UnityEngine.Serialization.FormerlySerializedAs("FreeSpinFinishAction")]
    public Action WageHerdShrineGreedy;

    protected override void Awake()
    {
        base.Awake();
        Instance = this;
        Modify_OK.onClick.AddListener(()=> {
            WageHerdShrineGreedy?.Invoke();
            ComicUIPram(nameof(FortWageHerdShrineCoach));
        });
    }

    public override void Display()
    {
        base.Display();
        GlobeYet.LawFigurine().ArchAdvent(GlobeThus.UIMusic.Sound_End_Windows);
        Mine_HerdLittle.text =  FortCopyVaguely.instance.WageHerdHimLittle.ToString();
        Mine_Have.text = FortCopyVaguely.instance.RunHerdMeadowLittle.ToString("f2");
        Slice_Have.sprite = FortCopyVaguely.instance.LawEnsueDuringHome(); 
    }
    public void MadHerdShrineGreedy(Action action)
    {
        WageHerdShrineGreedy = action;
    }
}
