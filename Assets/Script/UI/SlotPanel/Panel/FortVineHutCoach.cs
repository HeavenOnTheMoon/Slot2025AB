using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FortVineHutCoach : LeftUIMarry
{
[UnityEngine.Serialization.FormerlySerializedAs("CoinText")]    public Text HaveMine;
[UnityEngine.Serialization.FormerlySerializedAs("Image_Coin")]    public Image Slice_Have;
[UnityEngine.Serialization.FormerlySerializedAs("OpenButton")]    public Button TillModify;
[UnityEngine.Serialization.FormerlySerializedAs("Button_Close")]    public Button Modify_Comic;

    protected override void Awake()
    {
        base.Awake();
        TillModify.onClick.AddListener(OnOpenPig);
        Modify_Comic.onClick.AddListener(()=> {
            GlobeYet.LawFigurine().ArchDy(GlobeThus.SceneMusic.Sound_Quick7_Bgm);
            ComicUIPram(nameof(FortVineHutCoach));
        });
    }

    public override void Display()
    {
        base.Display();
        PageBisonEmbryo.LawFigurine().SeatBison("1013");
        HaveMine.text = FortWineCopyVaguely.LawFigurine().LeoBodeHutHome.ToString();
        Slice_Have.sprite = FortCopyVaguely.instance.LawEnsueDuringHome();
        GlobeYet.LawFigurine().ArchDy(GlobeThus.SceneMusic.Sound_Piggy_Bank_Shake);
    }

    private void OnOpenPig()
    {
        GlobeYet.LawFigurine().ArchDy(GlobeThus.SceneMusic.Sound_Quick7_Bgm);
        ADVaguely.Figurine.HookMeadowAlike((success) =>
        {
            if (success)
            {
                PageBisonEmbryo.LawFigurine().SeatBison("1014","1");
                Debug.Log("==============   ��ȡ��������  ��  " + FortWineCopyVaguely.LawFigurine().LeoBodeHutHome);
                FortWineCopyVaguely.LawFigurine().WineFistRotHome(FortWineCopyVaguely.LawFigurine().LeoBodeHutHome);
                FortWineCopyVaguely.LawFigurine().LawVineHutMeadow();
                ComicUIPram(nameof(FortVineHutCoach));
            }
            
        }, "7");
       
    }
}
